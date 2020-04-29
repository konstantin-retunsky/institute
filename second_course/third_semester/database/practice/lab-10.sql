/*
	10.1
	�������� ������, ������� ����������� �� ��������� ��� ���������
  ���� ������� ��� ��������� � ������ Cisneros. �����������, ��� ��
	�� ������ ������ ����� ���������, ������������ � ���� cnum.
*/
	Select *
		From Orders
			Where cnum = (
				Select cnum
					From Customers
						where cname = 'Cisneros'
			);
/*
	10.2
	�������� ������, ������� ����� �� ����� � ������ ���� ����������,
  ������� ���������� ������.
*/
Select distinct cname, rating
	From Customers, Orders
		Where amt > (
			Select avg(amt)
				From Orders
		)
		and Orders.cnum = Customers.cnum;
/*
	10.3
	�������� ������, ������� ������ �� ����� ����� ���� ������������
  � ������� ��� ������� ��������, � �������� ��� ����� ����� ������,
  ��� ����� ����������� ������ � �������.
*/


Select snum, sum( amt )
	From Orders
		Group by snum
			Having sum( amt ) > (
				SELECT max( amt )
					FROM Orders
			);