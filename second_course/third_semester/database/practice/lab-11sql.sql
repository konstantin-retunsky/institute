/*
	11.1
	�������� ������� SELECT, ������������ ������������ ���������,
  ������� ������� ����� � ������ ���� ���������� � ������������� 
	��� �� ������� ��������.
*/
Select cnum, cname
	From Customers first
		Where rating = (
			Select max( rating )
				From Customers second
					Where first.city = second.city
			);
/*
	11.2
	�������� ��� �������, ������� ������� ���� ��������� (�� �� �����
  � ������), ������� � ����� ������� ����������, ������� ��� ��
  �����������. ���� ������ - � �������������� �����������, � 
	������ - � ����������� �����������. ������� �� ������� 
	����� ����� �������?

	(���������: ���� �� �������� ������� ��� ������� � ���, ����� �����
  ���� ����������, �� ������������� ������ ���������, � ����������,
  ��������� �� ������ �� ��� � ������ ��������.)
*/

Select first.snum, first.sname
	From Salespeople first
		Where first.city = (
			Select distinct  second.city
				From Customers second 
					Where first.city = second.city
					and first.snum != second.snum
		);

Select distinct Salespeople.snum, Salespeople.sname
	From Salespeople, Customers
		Where Salespeople.city = Customers.city
		and Salespeople.snum != Customers.snum;
