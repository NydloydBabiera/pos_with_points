--NOTE: AFTER RUNNING THIS SCRIPT PLEASE CHECK EVERY TABLE AND SET 'IDENTITY SPECIFICATION' TO YES IN ORDER TO INCREMENT ID
--user credentials table
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'user_info_tbl' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].user_info_tbl;
GO
CREATE TABLE user_info_tbl(
    user_info_id BIGINT NOT NULL PRIMARY KEY,
    firstName varchar(255),
    middleName varchar(255),
    lastName varchar(255),
    userName varchar(255),
    user_password varchar(255),
	user_role varchar(255)
);
Go

--customer data table
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'customer_data_tbl' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].customer_data_tbl;
GO
CREATE TABLE customer_data_tbl(
    customer_id BIGINT NOT NULL PRIMARY KEY,
    firstName varchar(255),
    middleName varchar(255),
    lastName varchar(255),
	address text,
	customer_points bigint,
);
Go

--product table
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'product_tbl' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].product_tbl;
GO
CREATE TABLE product_tbl(
    product_id BIGINT NOT NULL PRIMARY KEY,
    product_name varchar(255),
	product_variant varchar(255),
    product_desc text,
	is_active bit,
	product_price decimal(18,2)
);
Go

--product line table
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'product_line_tbl' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].product_line_tbl;
GO
CREATE TABLE product_inventory_tbl(
    product_inventory_id BIGINT NOT NULL PRIMARY KEY,
	product_id BIGINT REFERENCES product_tbl(product_id),
    entry_date DATE,
	quantity BIGINT,
);
Go

--transaction table 
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'transactions_tbl' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].transactions_tbl;
GO
CREATE TABLE transactions_tbl(
    transaction_id BIGINT NOT NULL PRIMARY KEY,
    transaction_code varchar(255),
    customer_id BIGINT REFERENCES customer_data_tbl(customer_id),
    cashier_id BIGINT REFERENCES user_info_tbl(user_info_id),
    total_amount varchar(255),
    payment_type varchar(255) NOT NULL CHECK (payment_type IN('CASH','BANK')),
    check_no varchar(255),
    transaction_date DATE,
	discountType varchar(255),
	points_used bigint
);
GO

--transaction line table
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'transactions_line_tbl' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].transactions_line_tbl;
GO
CREATE TABLE transactions_line_tbl(
    transactions_line_id BIGINT NOT NULL PRIMARY KEY,
    transaction_code varchar(255),
	transaction_id BIGINT REFERENCES transactions_tbl(transaction_id),
    product_id BIGINT REFERENCES product_tbl(product_id),
    quantity BIGINT,
    amount decimal(18,2),
);
GO

