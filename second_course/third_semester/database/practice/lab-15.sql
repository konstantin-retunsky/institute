--/*
--	15.1
--	�������� �������, ������� ��������� �� ��������� �������� �
--  ��������� ������ � ������� ���������:
--  city - San Jose,
--  name - Bianco,
--  comm - NULL,
--  cnum - 1100.
--*/
--Insert into Salespeople	( city, sname, comm, snum )
--	Values ( 'San Jose', 'Bianco', NULL, 1100 );
--/*
--	15.2
--	�������� �������, ������� ������� �� ��� ������ ��������� Clemens
--  �� ������� �������
--*/
--Delete Orders
--	From Customers
--		Where Customers.cname = 'Tony'
--		and Orders.cnum = Customers.cnum;
--/*
--	15.3
--	�������� �������, ������� ��������� �� ������ ���� ���������� � ���� �� 100.
--*/
Update Customers
	Set rating = rating + 100
		Where Customers.city = 'Rome';
/*
--	15.4
--	�������� Serres ������� ��������. ������������� ��� ���������� �������� Motika.
--*/
--Update Customers
--	Set snum = 1004
--		Where snum = 1002;

    