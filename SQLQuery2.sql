--Select
select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

select * from Customers where City = 'London'

select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products where CategoryID = 1 order by UnitPrice desc

select COUNT(*) from Products

select categoryID, COUNT(*) adet from Products group by CategoryID

select CategoryID, COUNT(*) from Products where UnitPrice > 20
group by CategoryID having COUNT(*) < 10

select Products.ProductID, Products.ProductName, Products.UnitPrice , Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

--DTO data transform object

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

