--Type of Triangle solution https://www.hackerrank.com/challenges/what-type-of-triangle/submissions/code/250062573

SELECT CASE
  WHEN A+B <= C THEN "Not A Triangle"
  WHEN A+C <= B THEN "Not A Triangle"
  WHEN C+B <= A THEN "Not A Triangle"
  WHEN A=B AND A=C THEN "Equilateral"
  WHEN A=B   THEN "Isosceles"
  WHEN A=C   THEN "Isosceles"
  WHEN B=C   THEN "Isosceles"
  ELSE "Scalene"
  END
FROM TRIANGLES  
