--How many invoices were there in 2009, and what was the sales total for that year?
SELECT Count(*) AS InvoiceQuantity, SUM(Total) AS TotalSales FROM Invoice WHERE YEAR(InvoiceDate) = 2009;




