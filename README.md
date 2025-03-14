1\open appsettings.json, then you can change the database name or just create an empty database with the same name
2\update database in Package Manager Console, if you success, add some data into your tables
3\INSERT INTO Products (ProductName, Description, ImageUrl, Pricing, ShippingCost)
VALUES 
('Laptop', 'Laptop with 5090', 'https://123.com/laptop.jpg', 1450.00, 23.00),
('Iphone', 'The apple you want', 'https://123.com/phone.jpg', 923.99, 15.00),
('Headphones', 'Noise-canceling wireless headphones', 'https://123.com/headphones.jpg', 198.99, 10.00),
('Smartwatch', 'Fitness smartwatch for you', 'https://123.com/watch.jpg', 249.99, 12.50),
('Camera', 'Professional camera for you', 'https://123.com/camera.jpg', 112.00, 25.00);
4\INSERT INTO Users (UserName, Password, Email, PurchaseHistory, ShippingAddress)
VALUES 
('Tom', 'tom123', 'tom@123.com', 'Laptop,Phone', 'N3J 2S8'),
('Tim', 'tim123', 'tim@123.com', 'Apple,Headphones', 'N4J 2V8'),
('Bob', 'bob123', 'bob@123.com', 'Camera,Smartwatch', 'N5J 2V8'),
('David', 'david123', 'david@123.com', 'Monitor,Mouse', 'N2J 2G8'),
('Eve', 'eve123', 'eve@123.com', 'Keyboard,Charger', 'N3J 2VU8');
