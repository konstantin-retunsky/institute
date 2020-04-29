/*
	11.1
	Напишите команду SELECT, использующую соотнесенный подзапрос,
  которая выберет имена и номера всех заказчиков с максимальными 
	для их городов оценками.
*/
Select cnum, cname
	From Customers first
		Where rating = (
			Select max( rating )
				From Customers second
					Where first.city = second.city
			);
/*
	11.2
	Напишите два запроса, которые выберут всех продавцов (по их имени
  и номеру), имеющих в своих городах заказчиков, которых они не
  обслуживают. Один запрос - с использованием объединения, а 
	другой - с соотнесённым подзапросом. Которое из решений 
	будет более изящным?

	(Подсказка: один из способов сделать это состоит в том, чтобы найти
  всех заказчиков, не обслуживаемых данным продавцом, и определить,
  находится ли каждый из них в городе продавца.)
*/

Select first.snum, first.sname
	From Salespeople first
		Where first.city = (
			Select distinct  second.city
				From Customers second 
					Where first.city = second.city
					and first.snum != second.snum
		);

Select distinct Salespeople.snum, Salespeople.sname
	From Salespeople, Customers
		Where Salespeople.city = Customers.city
		and Salespeople.snum != Customers.snum;
