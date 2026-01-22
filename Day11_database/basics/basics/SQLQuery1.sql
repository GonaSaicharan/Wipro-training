CREATE DATABASE EcommerceDB;
USE EcommerceDB;

CREATE TABLE Product(
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL UNIQUE,
    Price DECIMAL(10,2) CHECK (Price > 0),
    Stock INT CHECK (Stock >= 0),
    CreatedDate DATE NOT NULL
);

CREATE TABLE Customer(
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    CreatedDate DATE NOT NULL
);

CREATE TABLE Orders(
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATE NOT NULL,
    TotalAmount DECIMAL(12,2) CHECK (TotalAmount >= 0),

    CONSTRAINT FK_Order_Customer
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

CREATE TABLE OrderItems(
    OrderItemID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT CHECK (Quantity > 0),
    Price DECIMAL(10,2) CHECK (Price > 0),

    CONSTRAINT FK_OrderItems_Order
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),

    CONSTRAINT FK_OrderItems_Product
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

INSERT INTO Product (ProductName, Price, Stock, CreatedDate)
VALUES ('Wireless Mouse', 799.99, 50, '2025-12-22');
INSERT INTO Customer (FullName, Email, Phone, CreatedDate)
VALUES ('Sai Charan', 'saicharan@gmail.com', '9876543210', '2025-12-22');
INSERT INTO Orders (CustomerID, TotalAmount, OrderDate)
VALUES (1, 1599.98, '2025-12-22');

select * from Customer;
select * from Orders;
select * from Product;
select * from OrderItems;

