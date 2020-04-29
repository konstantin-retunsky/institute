/*
	7.1
	�����������, ��� ������ �������� ����� 12% ������������. �������� 
	������ � ������� �������, ������� ������� ����� ������, ����� 
	�������� � ����� ������������ �������� �� ����� ������.
*/
Select onum, snum, amt * .12
	From Orders;
/*
	7.2
	�������� ������ � ������� ����������, ������� ��� �� ����� ������ 
	������� � ������ ������. ����� ������ ���� � ����� �����:
       For the city (city), the highest rating is: (rating).
*/
Select 'For the city (' + city + '),', 
			 'the highest rating is: (' + max( rating ) + ').'
	From Customers
		Group By city
			Order By 2 Desc;
/*
	7.3
	�������� ������, ������� ������� �� ������ ���������� � 
	���������� �������. ����� ���� ������/�������� (rating) 
	������ �������������� ������ ��������� � ��� �������.
*/
 Select rating, cname, cnum
	From Customers
		Order By 1 desc, 2 desc, 3 desc;

/*
	7.4
	�������� ������, ������� ������� �� ����� ������ �� ������ 
	���� � ������� ���������� � ���������� �������.
*/
Select odate, sum (amt)
	From Orders
		Group By odate
			Order By 2 desc;
