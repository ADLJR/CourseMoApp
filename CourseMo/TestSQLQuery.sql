-- REGISTER FOR CLASS LOOKUP
SELECT Courses.CRN, Students.NetID
FROM Courses
INNER JOIN Students
ON Students.NetID = 'alove5' AND Courses.CRN = 10634

-- update insert into registered
INSERT INTO 
Registered(CRN, NetID)
SELECT Courses.CRN, Students.NetID
FROM Courses
INNER JOIN Students
ON Students.NetID = 'sallen32' AND Courses.CRN = 10634