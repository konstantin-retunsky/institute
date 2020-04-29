/*
	10.1
	Напишите запрос, который использовал бы подзапрос для получения
  всех заказов для заказчика с именем Cisneros. Предположим, что вы
	не знаете номера этого заказчика, указываемого в поле cnum.
*/
	Select *
		From Orders
			Where cnum = (
				Select cnum
					From Customers
						where cname = 'Cisneros'
			);
/*
	10.2
	Напишите запрос, который вывел бы имена и оценки всех заказчиков,
  имеющих усреднённые заказы.
*/
Select distinct cname, rating
	From Customers, Orders
		Where amt > (
			Select avg(amt)
				From Orders
		)
		and Orders.cnum = Customers.cnum;
/*
	10.3
	Напишите запрос, который выбрал бы общую сумму всех приобретений
  в заказах для каждого продавца, у которого эта общая сумма больше,
  чем сумма наибольшего заказа в таблице.
*/


Select snum, sum( amt )
	From Orders
		Group by snum
			Having sum( amt ) > (
				SELECT max( amt )
					FROM Orders
			);