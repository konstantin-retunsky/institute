/*
	13.1
	�������� ������, ������� ������� �� ���� ����������, ��� 
	������ ����� ��� ������, ��� ����� (ANY) ������ ��������� Serres.
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
	��� ����� �������� �������������� ��������?

	cnum   cname     city     rating   snum
  2002   Giovanni  Rome      200     1003
  2003   Liu       San Jose  200     1002
  2004   Grass     Berlin    300     1002
  2008   Cisneros  SanJose   300     1007
	2009	 Alex			 Berlin		 300		 1001
*/

/*
	13.3
	�������� ������, ������������ ANY ��� ALL, ������� ������� �� ����
  ���������, ������� �� ����� ������� ����������, ������� � �� ������.
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
	�������� ������, ������� ������� �� ��� ������ � ������, ������, 
	��� ����� (� ������� ������) ��� ���������� � �������.
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
	�������� ���������� ������ � �������������� MAX.
*/
Select *
	From Orders
		Where amt > any (
			Select max( amt ) 
				From Orders, Customers
					Where Customers.city = 'London'
					and Orders.cnum = Customers.cnum
		);