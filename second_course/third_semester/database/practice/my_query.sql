/*Клиенты которые живут в одном городе с водителем*/
Select   *
	From clients 
		Where code_city = any(
			Select code_city
				From drivers 
		);

/*Клиенты в чьих городах проживает более 1 водителя*/
Select   full_name 
	From clients first
		Where 2 <= (
			Select count( drivers.code_city )
				From drivers
					Where drivers.code_city = first.code_city
		);

/*Клиенты которые ни разу не обслуживались водителем с индексом 7*/
Select *
  From clients 
    Where exists (
			Select *
        From drivers, orders
          Where  clients.code_clients = orders.code_client
								 and  orders.code_driver != 7
		);

-- Самая востребованная машина
Declare @codeAuto int;
DEclare @tempTable TABLE (code_auto INT,  code_orders int);
 
 insert into @tempTable SELECT  top(1) code_auto, count(code_orders)
	FROM orders 
		GROUP BY  code_auto 
			ORDER BY 2 desc;

set @codeAuto = (select  code_auto from @tempTable);

Select model
	From model_auto	
		Where code_model = (
			Select code_model 
				From car
					Where car.code_model = model_auto.code_model
					and car.num_auto = @codeAuto
		);

--лучший клиент
Declare @codeClient int;
DEclare @tempTableSum TABLE (code_client int,  sum int);

insert into @tempTableSum Select top (1) code_client, max(quantity * price_1_km)
	From orders, car
		Group by code_client
			Order by 2 desc;

set @codeClient = (Select code_client From @tempTableSum );

Select full_name
	From clients
		Where code_clients = @codeClient;


/*Водители и Клиенты живущие в London    */
Select * 
	From clients	
		Where clients.code_city = 1

Union 

Select * 
	From drivers
		Where drivers.code_city = 1;

/*Водители и Клиенты чей город начинается на M*/
Select * 
	From clients	
		Where clients.code_city = 1

Union 

Select * 
	From drivers
		Where drivers.code_city = 1;

--заказы 2019-05-01 числа
Select  code_orders, clients.full_name, drivers.full_name, date.date
	From date, orders, clients, drivers
		Where date.date = '2019-05-01'
		and orders.code_date = date.code_date
		and orders.code_client = clients.code_clients
		and orders.code_driver = drivers.code_drivers;

  --машины пылившиеся в гараже 2019-05-01 числа
Select model
	From car, model_auto, orders, date
		Where orders.code_auto = car.num_auto
		and car.code_model = model_auto.code_model
		and orders.code_date = date.code_date
		and date.date != '2019-05-01';

--вывод таблицы orders

Select code_orders, clients.full_name, drivers.full_name, model, date, quantity * price_1_km as 'Общая сумма'
	From car, model_auto, drivers, clients, date, orders
		Where orders.code_driver = drivers.code_drivers
		and orders.code_client = clients.code_clients
		and orders.code_date = date.code_date
		and model_auto.code_model = car.code_model
		and orders.code_auto = car.num_auto;
