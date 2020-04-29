/*
	7.1
	Предположим, что каждый продавец имеет 12% комиссионных. Напишите 
	запрос к таблице Заказов, который выведет номер заказа, номер 
	продавца и сумму комиссионных продавца по этому заказу.
*/
Select onum, snum, amt * .12
	From Orders;
/*
	7.2
	Напишите запрос к таблице Заказчиков, который мог бы найти высший 
	рейтинг в каждом городе. Вывод должен быть в такой форме:
       For the city (city), the highest rating is: (rating).
*/
Select 'For the city (' + city + '),', 
			 'the highest rating is: (' + max( rating ) + ').'
	From Customers
		Group By city
			Order By 2 Desc;
/*
	7.3
	Напишите запрос, который выводил бы список заказчиков в 
	нисходящем порядке. Вывод поля оценки/рейтинга (rating) 
	должен сопровождаться именем заказчика и его номером.
*/
 Select rating, cname, cnum
	From Customers
		Order By 1 desc, 2 desc, 3 desc;

/*
	7.4
	Напишите запрос, который выводил бы общие заказы на каждый 
	день и помещал результаты в нисходящем порядке.
*/
Select odate, sum (amt)
	From Orders
		Group By odate
			Order By 2 desc;
