-- Select
--ANSI Standard
-- SELECT ContactName Adı ,CompanyName ŞirketIsmi,City Şehir FROM Customers
-- Case insensitive

SELECT * From Customers Where City = 'Berlin'
SELECT * From Products where CategoryID = 1 or CategoryID = 2 
SELECT * From Products where CategoryID = 1 and UnitPrice > 10 
SELECT * FROM Products order by CategoryID,ProductName
SELECT * From Products order by UnitPrice desc -- ascending (default)
SELECT count(*) ProductCount from Products
SELECT CategoryID, count(*) productCount from Products group by CategoryID having count(*) < 10
SELECT CategoryID, count(*) productCount from Products where UnitPrice > 20 
group by CategoryID having count(*) < 10

SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.ProductID = Categories.CategoryID

--DTO (Data Transfer Object) 

select *
from Orders join [Order Details] 
on Orders.OrderId = [Order Details].OrderID
join Products on [Order Details].ProductId = Products.ProductId
--group by ProductName

select ProductName, sum(Products.UnitPrice * Quantity) totalIncome
from Orders join [Order Details] 
on Orders.OrderId = [Order Details].OrderID
join Products on [Order Details].ProductId = Products.ProductId
group by ProductName