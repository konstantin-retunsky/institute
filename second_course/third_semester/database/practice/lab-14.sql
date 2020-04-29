/*
	14.1
	�������� ����������� �� ���� ��������, ������� �������� �� �����,
  ������ � ������ ���� ����������. �� �� ���, ������� ����� ����
  rating=200 � �����, ������, ����� ����, ����� ����� - "�������
  �������", � ��������� ������ ����� ����� "������ �������".
*/
Select cname, city, '������� �������', rating 
	From Customers
		Where rating >= 200

Union

Select cname, city, '������ �������', rating 
	From Customers
		Where rating < 200;
/*
	14.2
	�������� �������, ������� ������ �� ����� � ������ ������� �������� �
  ������� ���������, ������� ����� ������ ��� ���� �������
  �����. ��������� ����������� � ���������� �������.
*/
Select snum, sname
	From Salespeople
		Where 2 >= (
			Select count( snum )
				From Orders
					Where Orders.snum = Salespeople.snum
		)

Union 

Select cnum, cname
	From Customers
		Where 2 >= (
			Select count( snum )
				From Orders
					Where Orders.snum = Customers.snum
		)
Order by 2;
/*
	14.3
	����������� ����������� �� ���� ��������. ������ �������� ����
  snum ���� ��������� � San Jose; ������, ���� cnum ���� ���������� �
  San Jose; � ������ - ���� onum ���� ������� �� 3 �������.
  ��������� ��������� ����� ���������� ����� ���������, ��
  ��������� ����� ������������ ������ ����� ������ �� ��� � ����� ������.

  (����������: � ������ ������� �������� �� ���������� ������� ������������.
  ��� ������ ������.)
*/
Select snum
	From Salespeople
		Where city = 'San Jose'

Union

Select cnum
	From Customers
		Where city = 'San Jose'

Union all

Select onum 
	From Orders
		Where odate = '10/03/1990';
