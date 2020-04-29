--/*
--	15.1
--	Напишите команду, которая поместила бы следующие значения в
--  указанном заказе в таблицу Продавцов:
--  city - San Jose,
--  name - Bianco,
--  comm - NULL,
--  cnum - 1100.
--*/
--Insert into Salespeople	( city, sname, comm, snum )
--	Values ( 'San Jose', 'Bianco', NULL, 1100 );
--/*
--	15.2
--	Напишите команду, которая удалила бы все заказы заказчика Clemens
--  из таблицы Заказов
--*/
--Delete Orders
--	From Customers
--		Where Customers.cname = 'Tony'
--		and Orders.cnum = Customers.cnum;
--/*
--	15.3
--	Напишите команду, которая увеличила бы оценку всех заказчиков в Риме на 100.
--*/
Update Customers
	Set rating = rating + 100
		Where Customers.city = 'Rome';
/*
--	15.4
--	Продавец Serres оставил компанию. Переназначьте его заказчиков продавцу Motika.
--*/
--Update Customers
--	Set snum = 1004
--		Where snum = 1002;

    