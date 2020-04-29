/*
	9.1
	Напишите запрос, который вывел бы все пары продавцов, живущих в одном и том же городе.
	Исключите комбинации продавцов с самими собой, а также дубликаты строк,
	выводимых в обратным порядке.
*/
Select first.sname, second.sname
	From Salespeople first, Salespeople second
		where first.city = second.city
		and first.sname < second.sname;
/*
	9.2
	Напишите запрос, который выведет все пары заказов по данным 
	заказчикам, имена	этих заказчиков и исключит дубликаты из вывода,
	как в предыдущем вопросе.
*/
Select DISTINCT cname, first.onum, second.onum
	From Customers, Orders first, Orders second
		Where Customers.cnum = first.cnum
		and first.cnum = second.cnum
		and first.onum < second.onum;
/*
	9.3
	Напишите запрос, который вывел бы имена (cname) и города (city)
	всех заказчиков.
*/
Select cname, city 
	From Customers;
	