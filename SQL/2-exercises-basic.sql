-- basic exercises (Chinook database)

-- 1. list all customers (full names, customer ID, and country) who are not in the US
select 
	FirstName + ' ' + LastName as [Full Name],
	CustomerId as [Customer ID],
	Country as [Country]
from Customer
where Country != 'USA';


-- 2. list all customers from brazil
select 
	FirstName + ' ' + LastName as [Customer]
from Customer
where Country = 'Brazil';

-- 3. list all sales agents
select 
	FirstName + ' ' + LastName as [Sales Agents]
from Employee
where Title = 'Sales Support Agent'

-- 4. show a list of all countries in billing addresses on invoices.
select 
	BillingCountry as [Billing Countries on invoices]
from Invoice;

-- 5. how many invoices were there in 2009, and what was the sales total for that year?
--    (extra challenge: find the invoice count sales total for every year, using one query)
select 
	--InvoiceDate as [Invoice Date in 2009],
	InvoiceDate as [Invoice Date in 2009],
	sum (Total)  as [Sales total in 2009]
from Invoice
where InvoiceDate like '%2009%'
group by InvoiceDate;

-- 6. how many line items were there for invoice #37?
select Quantity, InvoiceId
from InvoiceLine
where InvoiceId= 37;

-- 7. how many invoices per country?
select 
	BillingCountry as [Billing Country],
	count(InvoiceId) as [Total Invoices]
from Invoice
group by BillingCountry;

-- 8. show total sales per country, ordered by highest sales first.
select 
	BillingCountry as [BillingCountry],
	sum(Total) as [Total for Country]
from Invoice
group by BillingCountry order by sum(Total)DESC;


