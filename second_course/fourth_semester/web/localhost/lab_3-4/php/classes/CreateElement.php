<?php
	
	class CreateElement {
		
		public static function ProductItem( $array, $index ) {
			$name_product = $array[ 0 ];
			$manufacturer = $array[ 1 ];
			$category = $array[ 2 ];
			$cost = $array[ 3 ];
			$tool_tip = $array[ 4 ];
			$quantity_in_stock = $array[ 5 ];
			$check = $array[ 6 ];
			
			$check = $check == 1 ? "checked" : "";
			
			return "<div class=\"product-item\">" .
				"<img src=\"images/tent-$index.jpg\" onclick='alert(\"$tool_tip\")' class='show-info'>" .
				"<div name=\"name-tent\" >Название: $name_product</div>" .
				"<div name=\"manufacturer\">Производитель: $manufacturer</div>" .
				"<div name=\"category\">Категория: $category</div>" .
				"<div name=\"cost\">Цена: $cost</div>" .
				"<div name=\"quantity-in-stock\">Количество на складе: $quantity_in_stock</div>" .
				"<lable>Добавить в корзину  </lable>" .
				"<input alt='$index' type=\"checkbox\" value=\"Добавить в корзину\"  onclick='ChangesInCart( [this.checked,this.alt] )' $check>" .
				"</div>";
			
		}
		
		public static function ShooppingBasket( $array, $index ) {
			$name_product = $array[ 0 ];
			$manufacturer = $array[ 1 ];
			$cost = $array[ 3 ];
			$quantity_in_stock = $array[ 5 ];
			$value_start_quantity = $quantity_in_stock == 0 ? 0 : 1;
			
			return "<div class=\"item\" id='item_basket-$index'>" .
				"<div class=\"buttons\" onclick='CancelProductBasket($index);' ><span class=\"delete-btn\"></span></div>" .
				"<img class=\"image\" src=\"images/tent-$index.jpg\" alt=\"$index\"/>" .
				"<div class=\"description\">" .
				"<span>$name_product</span>" .
				"<span>$manufacturer</span>" .
				"<span alt='remainder'>Осталось: $quantity_in_stock</span>" .
				"</div>" .
				"<div class=\"quantity\">" .
				"<button class=\"plus-btn btn-basket\" type=\"button\" onclick='QuantityChange(this.attributes);' alt='$quantity_in_stock;$cost;$index;+' name=\"button\">" .
				"<img src=\"images/ico/plus.svg\" alt=\"\"/>" .
				"</button>" .
				"<input type=\"text\" alt='quantity' name=\"name\" value='$value_start_quantity' id='quantity-product-$index'>" .
				"<button class=\"minus-btn btn-basket\" type=\"button\" onclick='QuantityChange(this.attributes);' alt='$quantity_in_stock;$cost;$index;-' name=\"button\">" .
				"<img src=\"images/ico/minus.svg\" alt=\"\"/>" .
				"</button>" .
				"</div>" .
				"<div class=\"basket-price\"><span alt='$index'>$cost</span> руб.</div>" .
				"</div>";
		}
		
	}


?>