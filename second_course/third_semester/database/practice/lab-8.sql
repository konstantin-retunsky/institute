/*
	8.1
	Напишите запрос, который вывел бы список номеров заказов 
	сопровождающихся именем заказчика, который создавал эти заказы.
*/
 Select onum,  cname
	From Orders, Customers
		Where Orders.cnum = Customers.cnum;
/*
	8.2
	Напишите запрос, который выдавал бы имена продавца и заказчика 
	для каждого заказа после номера заказа.
*/
Select onum, cname, sname
	From Orders, Customers, Salespeople
		Where Orders.cnum = Customers.cnum and
					Orders.snum = Salespeople.snum;

/*
	8.3
	Напишите запрос, который выводил бы всех заказчиков, 
	обслуживаемых продавцом с комиссионными выше 12%. Выведите 
	имя заказчика, имя продавца и ставку комиссионных продавца.
*/
Select cname, sname, comm
 From Customers, Salespeople
	Where Customers.snum = Salespeople.snum and
				comm > .12;
/*
	8.4 
	Напишите запрос, который вычислил бы сумму комиссионных продавца 
	для каждого заказа заказчика с оценкой выше 100.
*/
Select onum, comm * amt
 From Salespeople, Orders, Customers
  Where rating > 100 and
				Orders.cnum = Customers.cnum and
				Orders.snum = Salespeople.snum;