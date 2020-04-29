/*
	9.1
	�������� ������, ������� ����� �� ��� ���� ���������, ������� � ����� � ��� �� ������.
	��������� ���������� ��������� � ������ �����, � ����� ��������� �����,
	��������� � �������� �������.
*/
Select first.sname, second.sname
	From Salespeople first, Salespeople second
		where first.city = second.city
		and first.sname < second.sname;
/*
	9.2
	�������� ������, ������� ������� ��� ���� ������� �� ������ 
	����������, �����	���� ���������� � �������� ��������� �� ������,
	��� � ���������� �������.
*/
Select DISTINCT cname, first.onum, second.onum
	From Customers, Orders first, Orders second
		Where Customers.cnum = first.cnum
		and first.cnum = second.cnum
		and first.onum < second.onum;
/*
	9.3
	�������� ������, ������� ����� �� ����� (cname) � ������ (city)
	���� ����������.
*/
Select cname, city 
	From Customers;
	