CREATE TABLE users
(
	id int PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR (MAX) NULL,
	role VARCHAR (MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL
		
)


DROP TABLE users;


INSERT INTO users (username, password, role, status) VALUES('testing1', 'admin123', 'Cashier', 'Active')

SELECT * FROM users

INSERT INTO users(username, password, role, status, date) VALUES('MainInventory',  'admin123', 'Admin', 'Active', '2024-10-11' )

CREATE TABLE categories
(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	date DATE NULL
)

SELECT * FROM categories

DROP TABLE categories;





CREATE TABLE products
(
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	price FLOAT NULL,
	stock INT NULL,
	image_path VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL,
)


UPDATE products 
SET stock = stock - @Quantity 
WHERE prod_id = @ProdId AND stock >= @Quantity


DROP TABLE products;



SELECT *FROM products

CREATE TABLE customers
(
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT NULL,
    prod_id VARCHAR(MAX) NULL,
    total_price FLOAT NULL,
    amount FLOAT NULL,
    change FLOAT NULL,
    order_date DATE NULL
);

SELECT * FROM customers

ALTER TABLE customers
DROP COLUMN prod_id

DROP TABLE customers;









INSERT INTO users (username, password, role, status, date)
VALUES ('newAdmin', 'securePassword123', 'Admin', 'Active', '2024-10-18');

CREATE TABLE orders 
(
	id int PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	qty INT NULL,
	orig_price FLOAT NULL,
	total_price FLOAT NULL,
	order_date DATE NULL,

)


ALTER TABLE ORDERS 
ADD customer_id INT NULL

DROP TABLE orders;

SELECT * FROM orders
