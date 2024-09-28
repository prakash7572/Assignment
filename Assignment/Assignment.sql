CREATE DATABASE Assignment
USE Assignment 

CREATE TABLE StudentCourses (
    Id          INT IDENTITY(1,1),
    StudentName NVARCHAR(100),
    Branch      VARCHAR(100),
    Subject     VARCHAR(100)
);
INSERT INTO StudentCourses (StudentName, Branch, Subject) VALUES 
    ('Aisha Khan', 'Computer Science', 'English'),
    ('Luka Rossi', 'Computer Science', 'English'),
    ('Emiko Tanaka', 'Computer Science', 'English'),
    ('Aisha Khan', 'Computer Science', 'Math'),
    ('Luka Rossi', 'Computer Science', 'Math'),
    ('Emiko Tanaka', 'Computer Science', 'Math'),
    ('Aisha Khan', 'Computer Science', 'Programming'),
    ('Luka Rossi', 'Computer Science', 'Programming'),
    ('Emiko Tanaka', 'Computer Science', 'Programming'),
    ('Mateo Garcia', 'Mechanical', 'English'),
    ('Jara Patel', 'Mechanical', 'English'),
    ('Jara Patel', 'Mechanical', 'Math'),
    ('Jara Patel', 'Mechanical', 'Math'),
    ('Jara Patel', 'Mechanical', 'Drawing'),
    ('Jara Patel', 'Mechanical', 'Drawing'),
    ('Eshtan Williams', 'Bio Medical', 'English'),
    ('Leila Muller', 'Bio Medical', 'English'),
    ('Eshtan Williams', 'Bio Medical', 'Biology'),
    ('Leila Muller', 'Bio Medical', 'English');


