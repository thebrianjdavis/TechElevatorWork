USE assessment;
GO

-- Select all the columns in cart where the username is kmilner1j

SELECT *
FROM assessment.dbo.carts
WHERE username like 'kmilner1j';

-- Select the id and name columns from items where the item was added on or after Jan. 15, 2019 and the weight is null

SELECT id, name
FROM assessment.dbo.items
WHERE added >= '2019-01-15';

-- Select username and the cookie_value from carts where the username isn't null, ordered by the created date, latest first

SELECT username, cookie_value
FROM assessment.dbo.carts
WHERE username IS NOT NULL
ORDER BY created DESC;

-- Select the added date and the count of all the items added on that date

SELECT added, COUNT(added) as item_count
FROM assessment.dbo.items
GROUP BY added;

-- Select the cart's username and created date and the item's name for all carts created in the month of Sept. 2019

SELECT c.username, c.created, i.name
FROM assessment.dbo.items i
JOIN assessment.dbo.carts c ON i.cart_id = c.id
WHERE c.created BETWEEN '2019-09-01' AND '2019-09-30'