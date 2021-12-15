--List all customers (full names, customer ID, and country) who are not in the US
SELECT FirstName, LastName, CustomerId, Country FROM Customer WHERE COUNTRY !='USA';




