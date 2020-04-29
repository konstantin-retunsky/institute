/*
	13.1
	Напишите запрос, который выбирал бы всех заказчиков, чьи 
	оценки равны или больше, чем любая (ANY) оценка заказчика Serres.
*/
	Select *
		From Customers
			Where rating >= any (
				Select rating
					From Customers, Salespeople
						Where Salespeople.sname = 'Serres'
						and Customers.snum = Salespeople.snum
			);
/*
	13.2
	Что будет выведено вышеупомянутой командой?

	cnum   cname     city     rating   snum
  2002   Giovanni  Rome      200     1003
  2003   Liu       San Jose  200     1002
  2004   Grass     Berlin    300     1002
  2008   Cisneros  SanJose   300     1007
	2009	 Alex			 Berlin		 300		 1001
*/

/*
	13.3
	Напишите запрос, использующий ANY или ALL, который находил бы всех
  продавцов, которые не имеют никаких заказчиков, живущих в их городе.
*/
Select * 
	From Salespeople 
		Where not (city = any (
			Select city 
				From Customers
		));
		

Select *
	From Salespeople
		Where city != all (
			Select city
				From Customers
			);
/*
	13.4
	Напишите запрос, который выбирал бы все заказы с суммой, больше, 
	чем любая (в обычном смысле) для заказчиков в Лондоне.
*/
Select *
	From Orders
		Where amt > any (
			Select amt 
				From Orders, Customers
					Where Customers.city = 'London'
					and Orders.cnum = Customers.cnum
		);
/*
	13.5
	Напишите предыдущий запрос с использованием MAX.
*/
Select *
	From Orders
		Where amt > any (
			Select max( amt ) 
				From Orders, Customers
					Where Customers.city = 'London'
					and Orders.cnum = Customers.cnum
		);