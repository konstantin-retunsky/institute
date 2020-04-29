<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>test-1</title>
</head>
<body>

</body>
</html>
<?php
	//	Входные данные:
	//	- php-файл класса html.php;
	//	- база данных по объектам (согласно варианту).
	//
	//	Выходные данные:
	//	PHP-файл(ы) для страниц,
	//	item.php — описание объекта,
	//	index.php  — главная страница.
	//
	//	Необходимо разработать приложения для вывода данных на страницу. На каждой странице должны присутствовать:
	//	1.	заголовок с логотипом
	//	2.	меню со списком объектов
	//	3.	описание объекта
	//	4.	фото
	//
	//	В классе HTMLPage определены следующие методы:
	//	function __construct($title) — создание и инициализация объекта (установка названия страницы).
	//	header() — вывод шапки.
	//	footer() — вывод «подвала» с копирайтом.
	//	logo() — вывод логотипа сайта.
	//	menu() — вывод главного меню сайта.
	//	content() — вывод основного содержания веб-страницы.
	//	write() — вывод веб-страницы, использующий методы для вывода отдельных элементов веб-страницы.
	
	Class HTMLPage {
		private $title;
		private $logo;
		private $header;
		private $menu;
		private $content;
		private $footer;
		
		
		function __construct ( $title = null, $logo = "logo.jpg",
			$header = "Справочник достопримечательностей города",
			$menu = null, $content = null, $footer = null
		) {
			$this -> title   = $title;
			$this -> logo    = $logo;
			$this -> header  = $header;
			$this -> menu    = $menu;
			$this -> content = $content;
			$this -> footer  = $footer;
		}
		
		function Title () {
			return $this -> title == ""
				?
				"<script>document.querySelector('title').innerHTML = \"Html Page\";</script>"
				:
				"<script>document.querySelector('title').innerHTML = \"$this->title\";</script>";
		}
		
		function Header () {
			return $this -> header == ""
				?
				"<header>" . $this -> Logo () . "Header</header>"
				:
				"<header>" . $this -> Logo () . " $this->header</header>";
		}
		
		function Logo () {
			return $this -> logo == ""
				?
				"<img width='100px' height='100px' src='../../images/logo.jpg'><br>"
				:
				"<img width='100px' height='100px' src='../../images/$this->logo'><br>";;
		}
		
		function Menu () {
			return $this -> menu == ""
				?
				"<main><div class=\"menu\">Menu</div>"
				:
				"<main><div class=\"menu\">$this->menu</div>";
		}
		
		function Content () {
			return $this -> content == ""
				?
				"<div class=\"content\">Content</div></main>"
				:
				"<div class=\"content\">$this->content</div></main>";
		}
		
		function Footer () {
			return $this -> footer == ""
				?
				"<footer>Footer</footer>"
				:
				"<footer>$this->footer</footer>";
		}
		
		function Write () {
			echo $this -> StylePage ();
			echo $this -> Header ();
			echo $this -> Menu ();
			echo $this -> Content ();
			echo $this -> Footer ();
			echo $this -> Title ();
		}
		
		function GetPage () {
			return $this -> StylePage () . $this -> Header () . $this -> Menu () .
			       $this -> Content () . $this -> Footer () . $this -> Title ();
		}
		
		function StylePage () {
			return file_get_contents ( "../../pattern/style_page.txt" );
		}
		
		static function CreateIndexphpAndItemphp () {
			//	Выходные данные:
			//	PHP-файл(ы) для страниц,
			//	item.php — описание объекта,
			//	index.php  — главная страница.
			
			//	Необходимо разработать приложения для вывода данных на страницу. На каждой странице должны присутствовать:
			//	1.	заголовок с логотипом
			//	2.	меню со списком объектов
			//	3.	описание объекта
			//	4.	фото
			
			
			$database  = new mysqli( "localhost", "bogeyman", "qwerty", "lab-1" );
			$table     = $database -> query ( "SELECT * FROM `var-1`" );
			$count_rows = mysqli_num_rows ( $table ); // количество полученных строк
			
			$menu    = "";
			$content = "";
			
			for ( $row_index = 0; $row_index < $count_rows; $row_index++ ) {
				$row     = mysqli_fetch_row ( $table );
				$menu    .= "<p><a href=\"#$row[0]\">$row[0]</a></p>\n";
				$content .= "<p><a name=\"$row[0]\"></a>$row[1]</p>" . "<img src='../../images/t0" . ($row_index.jpg + 1) . ".jpg'>" . "<br>";
			}
			
			$pattern_html = file_get_contents ( "../../pattern/pattern_html.txt" );
			
			$index_html = new HTMLPage(
				"index.html", "logo.jpg",
				"Шапка index.php файла ", $menu,
				"Это главная страница ;D", "подвал"
			);
			$item_html  = new HTMLPage(
				"item.html", "logo.jpg",
				"Шапка item.php файла ",
				$menu, $content, "подвал"
			);
			var_dump ($index_html->Menu ());
			
			$index_html = $pattern_html . $index_html -> GetPage () . "</body></html>";
			$item_html  = $pattern_html . $item_html -> GetPage () . "</body></html>";
			
			file_put_contents ( "index.html", $index_html );
			file_put_contents ( "item.html", $item_html );
		}
		
	}
	
	HTMLPage ::CreateIndexphpAndItemphp ();
	//	$htmlPage = new HTMLPage( "E" );
	//	$htmlPage -> Write ();
	//	$htmlPage -> CreateIndexphpAndItemphp ();

?>