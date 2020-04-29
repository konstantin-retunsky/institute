/*
	3.1
	�������� ������� SELECT, ������� ������ �� ����� ������, 
	����� � ���� ��� ����
	����� �� ������� �������.
*/

Select onum,amt,odate
	From Orders;

/*
	3.2
	�������� ������, ������� ����� �� ��� ������ �� ������� ����������, 
	��� �������	����� �������� = 1001.
*/

Select * 
	From Customers
		Where snum = 1001;

/*
	3.3
	�������� ������, ������� ����� �� ������� �� ��������� � 
	��������� �������: city, sname, snum, comm.
*/

Select city,sname,snum,comm
	From Salespeople;

/*
	3.4
	�������� ������� SELECT, ������� ������ �� ������ (rating), 
	�������������� ������ ������� ��������� � San Jose.
*/

Select rating, cname 
	From Customers
		Where city = 'SanJose';

/*
	3.5
	�������� ������, ������� ����� �� �������� snum ���� ��������� � 
	������� ������ �� ������� ������� ��� ����� �� �� �� ���� ����������.
*/

Select Distinct snum
	From Orders;