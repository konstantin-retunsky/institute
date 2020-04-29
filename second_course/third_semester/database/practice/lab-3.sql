/*
	3.1
	Напишите команду SELECT, которая вывела бы номер заказа, 
	сумму и дату для всех
	строк из таблицы Заказов.
*/

Select onum,amt,odate
	From Orders;

/*
	3.2
	Напишите запрос, который вывел бы все строки из таблицы Заказчиков, 
	для которых	номер продавца = 1001.
*/

Select * 
	From Customers
		Where snum = 1001;

/*
	3.3
	Напишите запрос, который вывел бы таблицу со столбцами в 
	следующем порядке: city, sname, snum, comm.
*/

Select city,sname,snum,comm
	From Salespeople;

/*
	3.4
	Напишите команду SELECT, которая вывела бы оценку (rating), 
	сопровождаемую именем каждого заказчика в San Jose.
*/

Select rating, cname 
	From Customers
		Where city = 'SanJose';

/*
	3.5
	Напишите запрос, который вывел бы значения snum всех продавцов в 
	текущем заказе из таблицы Заказов без каких бы то ни было повторений.
*/

Select Distinct snum
	From Orders;