/*
	8.1
	�������� ������, ������� ����� �� ������ ������� ������� 
	���������������� ������ ���������, ������� �������� ��� ������.
*/
 Select onum,  cname
	From Orders, Customers
		Where Orders.cnum = Customers.cnum;
/*
	8.2
	�������� ������, ������� ������� �� ����� �������� � ��������� 
	��� ������� ������ ����� ������ ������.
*/
Select onum, cname, sname
	From Orders, Customers, Salespeople
		Where Orders.cnum = Customers.cnum and
					Orders.snum = Salespeople.snum;

/*
	8.3
	�������� ������, ������� ������� �� ���� ����������, 
	������������� ��������� � ������������� ���� 12%. �������� 
	��� ���������, ��� �������� � ������ ������������ ��������.
*/
Select cname, sname, comm
 From Customers, Salespeople
	Where Customers.snum = Salespeople.snum and
				comm > .12;
/*
	8.4 
	�������� ������, ������� �������� �� ����� ������������ �������� 
	��� ������� ������ ��������� � ������� ���� 100.
*/
Select onum, comm * amt
 From Salespeople, Orders, Customers
  Where rating > 100 and
				Orders.cnum = Customers.cnum and
				Orders.snum = Salespeople.snum;