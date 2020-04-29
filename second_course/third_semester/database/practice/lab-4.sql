/*
	4.1
	�������� ������, ������� ����� ������ ��� ��� ������ �� 
	���������� ����� ���� $1,000.
*/
	Select *
		From Orders
			Where amt > 1000;
/*
	4.2
	�������� ������, ������� ����� ������ ��� ���� sname � city ���
	���� ��������� � ������� � ������������� ���� .10.
*/
	Select sname, city
		From Salespeople
			Where comm > + .10 and 
						city = 'London';
/*
	4.3
	�������� ������ � ������� ����������, ��� ����� ������� ���� 
	���������� � ������� =< 100, ���� ��� �� ��������� � ����.
*/
	Select *
		From Customers 
			Where rating <= 100 and not 
						city = 'Rome';
/*
	4.4
	��� ����� ���� �������� � ���������� ���������� �������?
              SELECT *
                 FROM Orders
                 WHERE (
						 amt < 1000 OR
							NOT (odate = 10/03/1990 AND cnum > 2003)
					 );

   onum    amt      odate       cnum  snum

   3001    18.69    10/03/1990  2008  1007
   3003    767.19   10/03/1990  2001  1001
   3005    5160.45  10/03/1990  2003  1002
   3009    1713.23  10/04/1990  2002  1003
   3007    75.75    10/04/1990  2004  1002
   3008    4723.00  10/05/1990  2006  1001
   3010    1309.95  10/06/1990  2004  1002
   3011    9891.88  10/06/1990  2006  1001
*/

/*
	4.5
	��� ����� ���� �������� � ���������� ���������� �������?
              SELECT *
                 FROM Orders
                 WHERE NOT ((odate = 10/03/1990 OR snum > 1006)
                    AND amt > = 1500 );

  onum  amt      odate   	  cnum   snum
 
  3001  18.69    10/03/1990   2008   1007
  3003  767.19   10/03/1990   2001   1001
  3006  1098.16  10/03/1990   2008  1007
  3009  1713.23  10/04/1990   2002  1003
  3007  75.75    10/04/1990   2004  1002
  3008  4723.00  10/05/1990   2006  1001
  3010  1309.95  10/06/1990   2004  1002
  3011  9891.88  10/06/1990   2006  1001
*/


/*
  4.6
  ��� ����� ����� ���������� ����� ������?
            SELECT snum, sname, city, comm
               FROM Salespeople
               WHERE (comm > + .12 OR
                  comm < .14);

   SELECT *
      FROM Salespeople;
*/
