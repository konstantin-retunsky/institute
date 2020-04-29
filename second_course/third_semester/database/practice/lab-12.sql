
/*
	12.1
	�������� ������, ������� ����������� �� �������� EXISTS ��� 
	���������� ���� ���������, ������� ���������� � ������� 300.
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
	��� �� �� ������ ���������� ��������, ��������� �����������?
*/
Select sname
	From Salespeople, Customers
		Where Salespeople.snum = Customers.snum
		and Customers.rating = 300;
/*
	12.3
	�������� ������, ������������ �������� EXISTS, ������� �������
  ���� ��������� � �����������, ������������ � �� �������, 
	������� ��� �� �������������.
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
	�������� ������, ������� �������� �� �� ������� ���������� �������
  ���������, ������������ ��������, ������� � ������ ������ �����
  �� ������� ���� ��� ������ ��������� (����� ���������, �������� ��
  ��������) � �������� � ������� ������� (���������: ��� �����
  ���� ������ �� ��������� � ������� � ����� ������������� 
	�����������).
*/
Select Customers.cname
	From Customers
		Where Exists (
			Select snum
				From Orders 
					Where Customers.snum = Orders.snum
					and Customers.cnum !=  Orders.cnum
		);