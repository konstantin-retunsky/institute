<?php
	
	//1,Hector,L,Curtis,male,San Antonio,TX,HectorLCurtis@mailinator.com,210-274-6193,11/28/1935,Training director,Waves Music,60.4,175,1592 Freshour Circle,78212,US
	class DatabaseDump {
		
		public static function MatchesEmail ( $value ) {
			
			$checkEmail = '/^\w+@\w+\.\w{1,5}$$/';
			
			if ( preg_match ( $checkEmail, $value ) ) {
				return true;
			} else {
				return false;
			}
		}//IsEmail
		
		public static function FixEmail ( &$value, $boolean ) {
			
			if ( !$boolean ) {
				$quantityAt = substr_count ( $value, "@" ) - 1;
				$value      = preg_replace ( '/@/', '', $value, $quantityAt );
			}
		} //FixEmail
		
		public static function MatchesGender ( $value ) {
			
			$checkGender = '/(male|female)/';
			
			if ( preg_match ( $checkGender, $value ) ) {
				return true;
			} else {
				return false;
			}
		}//IsGender
		
		public static function FixGender ( &$value ) {
			
			$checkMale   = '/^male$/';
			$checkFemale = '/^female$/';
			
			if ( preg_match ( $checkMale, $value ) ) {
				$value = '1';
			} else if ( preg_match ( $checkFemale, $value ) ) {
				$value = '0';
			} else {
				$value = 'нет пола';
			}
		}//FixGender
		
		public static function MatchesPhone ( $value ) {
			
			$checkPhone = '/\d+\-\d+\-\d+/';
			
			if ( preg_match ( $checkPhone, $value ) ) {
				return true;
			} else {
				return false;
			}
		}//IsPhone
		
		public static function FixPhone ( &$value ) {
			
			$unnecessaryCharacters = "/[^\d]+/";
			$value                 = preg_replace ( $unnecessaryCharacters, '', $value, -1 );
			
			$countValue = strlen ( $value );
			
			$value                    = str_split ( $value );
			$value[ $countValue - 4 ] = '-' . $value[ $countValue - 5 ];
			$value[ $countValue - 7 ] = '-' . $value[ $countValue - 5 ];
			$value                    = join ( '', $value );
		}//FixPhone
		
		public static function MatchesAddress ( $value ) {
			
			$checkAddress = '/\d+[A-z\'\s]+/';
			
			if ( preg_match ( $checkAddress, $value ) ) {
				return true;
			} else {
				return false;
			}
		}//IsAddress
		
		public static function FixAddress ( &$value, $boolean ) {
			
			if ( !$boolean ) {
				$unnecessaryCharacters = '/[^\dA-z\'\s]/';
				$value                 = preg_replace ( $unnecessaryCharacters, '', $value );
			}
			
			$value = explode ( ' ', $value );
			$temp  = ', ' . $value[ 0 ];
			unset( $value[ 0 ] );
			$value = join ( ' ', $value ) . $temp;
		}//FixAddress
		
		public static function FixRowIndex ( &$value ) {
			
			$countValue = strlen ( $value );
			
			for ( $i = $countValue; $i < 6; $i++ ) {
				$value = '0' . $value;
			}
		}//FixRowIndex
		
		public static function FixDate ( &$value ) {
			//d.	Дата рождения: Перевести из формата м/д/гггг в дд.мм.гггг, т.е. 1/7/1950 (7 января 1950) к 07.01.1950, 8/18/1985 -> 18.08.1985.
			$value      = explode ( '/', $value );
			$temp       = $value[ 0 ];
			$value[ 0 ] = $value[ 1 ];
			$value[ 1 ] = $temp;
			
			for ( $i = 0; $i < count ( $value ); $i++ ) {
				$countValue = strlen ( $value[ $i ] );
				if ( $countValue < 2 ) {
					$value[ $i ] = '0' . $value[ $i ];
				}
			}
			
			$value = join ( '.', $value );
		}//FixDate
		
		public static function FixWeight ( &$value ) {
			$value = round ( $value );
		}
		
	}//DatabaseDump

?>