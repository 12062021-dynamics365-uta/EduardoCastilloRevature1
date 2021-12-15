--How many invoices per country?
SELECT BillingCountry, COUNT(InvoiceId) AS InvoicesPerCountry FROM Invoice GROUP BY BillingCountry;


