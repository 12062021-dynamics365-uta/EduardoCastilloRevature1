CREATE TABLE Customers
(
   CustomerID INT NOT NULL IDENTITY PRIMARY KEY,
   Name VARCHAR(30),
   LastName VARCHAR(30)
);

ALTER TABLE Customers ADD Password VARCHAR(20);

CREATE TABLE Stores
(
   StoreName VARCHAR(30) NOT NULL PRIMARY KEY
);

CREATE TABLE Orders
(
   OrderID INT NOT NULL IDENTITY PRIMARY KEY,
   CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customers(CustomerID),
   StoreName VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Stores(StoreName),
   OrderedDate DATE NOT NULL,
   Total DECIMAL NOT NULL
);

CREATE TABLE Products
(
   ProductName VARCHAR(30) NOT NULL PRIMARY KEY, 
   Price DECIMAL NOT NULL,
   Description VARCHAR(30)
);

CREATE TABLE Purchases
(
   PurchasesID INT NOT NULL IDENTITY PRIMARY KEY,
   ProductName VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Products(ProductName),
   OrderID INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderID)
);

CREATE TABLE Inventory
(
   InventoryID INT NOT NULL IDENTITY PRIMARY KEY,
   ProductName VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Products(ProductName),
   StoreName VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Stores(StoreName)
);

INSERT INTO Stores (StoreName) values ('PCMart');
INSERT INTO Stores (StoreName) values ('BestBytes');
INSERT INTO Stores (StoreName) values ('HomeLaptops');
INSERT INTO Stores (StoreName) values ('PhoneDepot');

ALTER TABLE Products ALTER COLUMN ProductName VARCHAR(50);
ALTER TABLE Products ALTER COLUMN Description VARCHAR(100);