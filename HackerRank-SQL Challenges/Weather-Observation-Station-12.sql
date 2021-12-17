-- Weather Observation Station 12 https://www.hackerrank.com/challenges/weather-observation-station-12/submissions/code/247591195

SELECT DISTINCT CITY FROM STATION WHERE CITY NOT LIKE '[aeiou]%' and CITY NOT LIKE '%[aeiou]';