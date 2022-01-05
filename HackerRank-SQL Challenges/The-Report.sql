--The Report solution https://www.hackerrank.com/challenges/the-report/submissions/code/250020614


SELECT Name, Grade, Marks FROM Students INNER JOIN Grades ON 
Marks >= Min_Mark AND Marks <= Max_Mark AND Marks > 69 ORDER BY Grade DESC, Name; 

SELECT Null AS Name, Grade, Marks FROM Students INNER JOIN Grades ON
Marks >= Min_Mark AND Marks <= Max_Mark AND Marks <= 69 ORDER BY Grade DESC, Marks ASC;