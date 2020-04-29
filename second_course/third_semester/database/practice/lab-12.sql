
/*
	12.1
	Напишите запрос, который использовал бы оператор EXISTS для 
	извлечения всех продавцов, имеющих заказчиков с оценкой 300.
*/
Select sname
	From Salespeople
		Where Exists (
			Select rating
				From Customers
					Where Salespeople.snum = Customers.snum
					and rating = 300
		);
/*
	12.2
	Как бы вы решили предыдущую проблему, используя объединение?
*/
Select sname
	From Salespeople, Customers
		Where Salespeople.snum = Customers.snum
		and Customers.rating = 300;
/*
	12.3
	Напишите запрос, использующий оператор EXISTS, который выберет
  всех продавцов с заказчиками, размещёнными в их городах, 
	которые ими не обслуживаются.
*/
Select Salespeople.sname
	From Salespeople
		Where Exists (
			Select Customers.city
				From Customers
					Where Salespeople.city = Customers.city
					and Salespeople.snum != Customers.snum
		);
/*
	12.4
	Напишите запрос, который извлекал бы из таблицы Заказчиков каждого
  заказчика, назначенного продавцу, который в данный момент имеет
  по крайней мере ещё одного заказчика (кроме заказчика, которого вы
  выберете) с заказами в таблице Заказов (подсказка: это может
  быть похоже на структуру в примере с нашим трехуровневым 
	подзапросом).
*/
Select Customers.cname
	From Customers
		Where Exists (
			Select snum
				From Orders 
					Where Customers.snum = Orders.snum
					and Customers.cnum !=  Orders.cnum
		);