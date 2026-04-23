-- Write your query below
SELECT name FROM customers LEFT JOIN orders ON customers.ID = orders.customer_id
    WHERE orders.id IS NULL