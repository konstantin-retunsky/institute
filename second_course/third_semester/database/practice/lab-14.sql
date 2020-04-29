/*
	14.1
	Создайте объединение из двух запросов, которое показало бы имена,
  города и оценки всех заказчиков. Те из них, которые имеют поле
  rating=200 и более, должны, кроме того, иметь слова - "Высокий
  Рейтинг", а остальные должны иметь слова "Низкий Рейтинг".
*/
Select cname, city, 'Высокий Рейтинг', rating 
	From Customers
		Where rating >= 200

Union

Select cname, city, 'Низкий Рейтинг', rating 
	From Customers
		Where rating < 200;
/*
	14.2
	Напишите команду, которая вывела бы имена и номера каждого продавца и
  каждого заказчика, которые имеют больше чем один текущий
  заказ. Результат представьте в алфавитном порядке.
*/
Select snum, sname
	From Salespeople
		Where 2 >= (
			Select count( snum )
				From Orders
					Where Orders.snum = Salespeople.snum
		)

Union 

Select cnum, cname
	From Customers
		Where 2 >= (
			Select count( snum )
				From Orders
					Where Orders.snum = Customers.snum
		)
Order by 2;
/*
	14.3
	Сформируйте объединение из трех запросов. Первый выбирает поля
  snum всех продавцов в San Jose; второй, поля cnum всех заказчиков в
  San Jose; и третий - поля onum всех заказов на 3 октября.
  Сохраните дубликаты между последними двумя запросами, но
  устраните любую избыточность вывода между каждым из них и самым первым.

  (Примечание: в данных типовых таблицах не содержится никакой избыточности.
  Это только пример.)
*/
Select snum
	From Salespeople
		Where city = 'San Jose'

Union

Select cnum
	From Customers
		Where city = 'San Jose'

Union all

Select onum 
	From Orders
		Where odate = '10/03/1990';
