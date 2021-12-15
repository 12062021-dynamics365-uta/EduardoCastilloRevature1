--Show total sales per country, ordered by highest sales first, in the 2011
SELECT BillingCountry, SUM(Total) AS TotalSales FROM Invoice WHERE YEAR(InvoiceDate) = 2009 GROUP BY BillingCountry ORDER BY SUM(Total) DESC ;


