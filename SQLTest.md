# TestApp
/*1 запрос*/
SELECT DISTINCT s.Name
  FROM Salesperson AS s 
    INNER JOIN Orders AS o
    ON s.ID = o.salesperson_id 
    INNER JOIN Customer AS c
    ON o.cust_id = c.ID
 WHERE c.Name = 'Seamens';
 
 /*2 запрос*/
SELECT DISTINCT s.Name
  FROM Salesperson AS s
 EXCEPT 
     (SELECT s.Name
        FROM Salesperson AS s 
          INNER JOIN Orders AS o
          ON s.ID = o.salesperson_id 
          INNER JOIN Customer AS c
          ON o.cust_id = c.ID 
       WHERE c.Name = 'Seamens');
     
/*3 запрос*/
SELECT DISTINCT s.Name
  FROM Salesperson AS s 
    INNER JOIN Orders AS o
    ON s.ID = o.salesperson_id 
 WHERE 
     (SELECT COUNT(o.salesperson_id) 
        FROM Orders AS o 
       WHERE s.ID = o.salesperson_id) >= 2;

/*4 запрос*/
INSERT INTO TopSales(Name, Age)
SELECT Name, Age
  FROM Salesperson s
 WHERE Salary > 100000;
