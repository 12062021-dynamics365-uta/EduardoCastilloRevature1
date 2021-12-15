--Show total sales per country, ordered by highest sales first.
SELECT BillingCountry, SUM(Total) AS TotalSales FROM Invoice GROUP BY BillingCountry ORDER BY SUM(Total) DESC;


