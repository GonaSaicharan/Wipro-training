-- Courses( Master table )-- Students ( transaction Table)-- Trainers( Self Join use cases)CREATE TABLE MyCourses (    CourseId INT PRIMARY KEY,    CourseName VARCHAR(100));CREATE TABLE My_Students (    StudentId INT PRIMARY KEY,    StudentName VARCHAR(50),    CourseId INT);CREATE TABLE Trainers (    TrainerId INT PRIMARY KEY,    TrainerName VARCHAR(50),    ManagerId INT);INSERT INTO MyCourses (CourseId, CourseName) VALUES
(1, 'SQL'),
(2, 'Python'),
(3, 'Java'),
(4, 'Cloud Computing');
INSERT INTO My_Students (StudentId, StudentName, CourseId) VALUES
(101, 'Sai', 1),
(102, 'Ravi', 2),
(103, 'Anu', 1),
(104, 'Kiran', 3);INSERT INTO Trainers VALUES
(1, 'Arjun', NULL),
(2, 'Ravi', 1),
(3, 'Sneha', 1),
(4, 'Kiran', 2);

--JOINS

--1. INNER JOIN
SELECT c.CourseId, s.StudentName FROM MyCourses c
INNER JOIN My_Students s
ON s.CourseId=c.CourseId;

--2. LEFT JOIN
SELECT s.StudentId, s.StudentName, c.CourseId, c.CourseName FROM MyCourses c
LEFT JOIN My_Students s
ON s.CourseId=c.CourseId;


--FULL OUTER JOIN
--USE WHEN YOU NEED A QUICK SNAPSHOT
SELECT s.StudentId, s.StudentName, c.CourseId, c.CourseName FROM MyCourses c
FULL OUTER JOIN My_Students s
ON s.CourseId=c.CourseId;


--SELF JOIN
--table joins to itself
--USE THIS FOR HIERARCHY
SELECT
t1. TrainerName AS Trainers,
t2. TrainerName AS Manager
FROM Trainers t1
LEFT JOIN Trainers t2
ON t1.ManagerId = t2. TrainerId;

--CROSS JOIN
--RETURNS CARTESIAN PRODUCT (ALL POSSIBLE COMBINATIONS)
--USE IN TESTING AND SIMULATION
SELECT s.StudentName, c.CourseName FROM My_Students s
CROSS JOIN MyCourses c;

--UNION
--Combine result and remove duplicate
SELECT StudentName from My_Students
UNION
SELECT Trainername FROM Trainers;

--INTERSECT
--RETURNING COMMON RECORD
SELECT StudentName from My_Students
INTERSECT
SELECT Trainername FROM Trainers;


--EXCEPT
--SQL Server uses EXCEPT instead of MINUS.
--return distinct rows from the first (left) query that do not appear in the result set of the second (right) query
SELECT StudentName from My_Students
EXCEPT
SELECT Trainername FROM Trainers;