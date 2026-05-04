SELECT DISTINCT seller_name  FROM seller LEFT JOIN orders 
ON orders.seller_id = seller.seller_id
WHERE seller.seller_id NOT IN(
    SELECT seller_id
    FROM orders
    WHERE sale_date BETWEEN '2020-01-01' AND '2020-12-31'
)
ORDER BY seller.seller_name ASC