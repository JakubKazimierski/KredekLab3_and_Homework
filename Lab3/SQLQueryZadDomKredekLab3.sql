CREATE TABLE Role(
RoleId int IDENTITY(1,1) Primary key,
RoleName nvarchar(30)
);

CREATE TABLE Worker(
UserId int IDENTITY(1,1) Primary key,
Name nvarchar(30),
Surname nvarchar(30),
Pesel int,
RoleId int Foreign key REFERENCES Role(RoleId)
);


SET IDENTITY_INSERT Worker OFF

CREATE TABLE Salary(
SalaryId int IDENTITY(1,1) Primary key,
SalaryInt int,
UserId int Foreign key REFERENCES Worker(UserId)
);

SET IDENTITY_INSERT Salary OFF

CREATE TABLE Student(
StudentId int IDENTITY(1,1) Primary key,
Name nvarchar(30),
Surname nvarchar(30),
Pesel int,
Class nvarchar(30)
);
SET IDENTITY_INSERT Student OFF

CREATE TABLE ClassTeacher(
ClassId int IDENTITY(1,1) Primary key,
UserId int Foreign key REFERENCES Worker(UserId),
Class nvarchar(30)
);
SET IDENTITY_INSERT ClassTeacher OFF

CREATE TABLE Grades(
GradesStudentId int IDENTITY(1,1) Primary key,
StudentId int Foreign key REFERENCES Student(StudentId),
Grade nvarchar(30)
);

SET IDENTITY_INSERT Grades OFF

CREATE TABLE LogIns(
LogId int IDENTITY(1,1) Primary key,
UserPesel int,
UserName nvarchar(30),
UserPassword nvarchar(30)
);
SET IDENTITY_INSERT LogIns ON

INSERT [dbo].[Role] ( [RoleName]) VALUES ( 'Dyrektor')
INSERT [dbo].[Role] ( [RoleName]) VALUES ( 'Nauczyciel')
INSERT [dbo].[Role] ( [RoleName]) VALUES ( 'PracownikSekretariatu')
INSERT [dbo].[Role] ( [RoleName]) VALUES ( 'PanWozny ')

INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (1, 'Adam', 'Miskowiak', 630217919, 1)

INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (2, 'Milowicz', 'Karolak', 730606974, 2)
INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (3, 'Dio', 'ApproachingMe', 610520474, 2)
INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (4, 'Kargul', 'Bareja', 871105764, 2)

INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (5, 'Ricardo', 'Milos', 910605667, 2)
INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (6, 'Krystian', 'Karczynski', 450809129, 2)
INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (7, 'General', 'Kenobi', 940613499, 2)

INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (8, 'Enrique', 'Eglesias', 700210376, 2)
INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (9, 'Pepe', 'SadFrog', 920421445, 2)
INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (10, 'NoIPan', 'PawelOczywiscie', 500410735, 2)

INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (11, 'HackerMan', 'Witos', 540410735, 3)
INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (12, 'Marylin', 'Monroe', 340410335, 3)

INSERT [dbo].[Worker] ( [UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (13, 'Leon', 'Zawodowiec', 340410336, 4)




INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (1, 10000 , 1)

INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (2, 12000 , 2)
INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (3, 110000 , 3)
INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (4, 100 , 4)

INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (5, 69420 , 5)
INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (6, 1299 , 6)
INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (7, 3333 , 7)

INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (8, 6666 , 8)
INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (9, 1700 , 9)
INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (10, 5420 , 10)

INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (11, 6230 , 11)
INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (12, 69000 , 12)

INSERT [dbo].[Salary] ( [SalaryId], [SalaryInt], [UserId]) VALUES (13, 99999 , 13)




INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (1, 'Michal' , 'Krasny', 990613499, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (2, 'Aldona' , 'Warum', 991113499, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (3, 'Armin' , 'Witek', 991013499, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (4, 'Wieslaw' , 'Wszywka', 991013489, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (5, 'Jakub' , 'Lineski', 991013488, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (6, 'Jakub' , 'Larry', 991012488, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (7, 'Janina' , 'Lawry', 991012188, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (8, 'Jeremy' , 'Jones', 981012188, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (9, 'Piotr' , 'Klein', 981011188, '1a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (10, 'Marek' , 'Kleczkowski', 971011188, '1a')

INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (11, 'Marek' , 'Krasny', 890613499, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (12, 'Ania' , 'Warum', 891113499, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (13, 'Asia' , 'Witek', 891013499, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (14, 'Witolda' , 'Wszywka', 891013489, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (15, 'John' , 'Lineski', 891013488, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (16, 'Jerry' , 'Larry', 891012488, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (17, 'Jasny' , 'Lawry', 891012188, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (18, 'Jensen' , 'Jones', 881012188, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (19, 'Pawel' , 'Klein', 881011188, '1b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (20, 'Maria' , 'Kleczkowska', 871011188, '1b')

INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (21, 'Michal' , 'Kewski', 990613489, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (22, 'Aldona' , 'Wilska', 991113489, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (23, 'Armin' , 'Wielki', 991013489, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (24, 'Wieslaw' , 'Wojewoda', 991013499, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (25, 'Jakub' , 'Lirew', 991013498, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (26, 'Jakub' , 'Kiel', 991012498, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (27, 'Janina' , 'Opania', 991012198, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (28, 'Jeremy' , 'Tym', 981012198, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (29, 'Piotr' , 'Milos', 981011198, '1c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (30, 'Marek' , 'Kisne', 971011198, '1c')

INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (31, 'Adam' , 'Krasny', 790613499, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (32, 'Alex' , 'Warum', 791113499, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (33, 'Ambrozy' , 'Witek', 791013499, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (34, 'Witold' , 'Wszywka', 791013489, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (35, 'Kamil' , 'Lineski', 791013488, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (36, 'Kevin' , 'Larry', 791012488, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (37, 'Patryk' , 'Lawry', 791012188, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (38, 'Karol' , 'Jones', 781012188, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (39, 'Mateusz' , 'Klein', 781011188, '2a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (40, 'Ada' , 'Kleczkowska', 771011188, '2a')

INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (41, 'Michal' , 'Chrobry', 690613499, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (42, 'Aldona' , 'Sobieski', 691113499, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (43, 'Armin' , 'August', 691013499, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (44, 'Wieslaw' , 'Chodkiewicz', 691013489, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (45, 'Jakub' , 'Batory', 691013488, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (46, 'Jakub' , 'Car', 691012488, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (47, 'Janina' , 'Mickiewicz', 691012188, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (48, 'Jeremy' , 'S³owacki', 681012188, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (49, 'Piotr' , 'Norwid', 681011188, '2b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (50, 'Marek' , 'Anonim', 671011188, '2b')

INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (51, 'Miko³aj' , 'Krasny', 590613499, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (52, 'Marianna' , 'Warum', 591113499, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (53, 'Alojzy' , 'Witek', 591013499, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (54, 'Witold' , 'Wierzbicki', 591013489, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (55, 'Jimmy' , 'Lineski', 591013488, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (56, 'Johnatan' , 'Larry', 591012488, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (57, 'Dio' , 'Lawry', 591012188, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (58, 'Dariusz' , 'Jones', 581012188, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (59, 'Joseph' , 'Klein', 581011188, '2c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (60, 'Armani' , 'Kleczkowski', 571011188, '2c')

INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (61, 'Michal' , 'Krzysiak', 490613499, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (62, 'Aldona' , 'Chor¹¿y', 491113499, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (63, 'Armin' , '¯ó³æ', 491013499, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (64, 'Wieslaw' , 'Polski', 491013489, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (65, 'Jakub' , 'Niemiecki', 491013488, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (66, 'Jakub' , 'Rosyjski', 491012488, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (67, 'Janina' , 'Litewski', 491012188, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (68, 'Jeremy' , 'Nordycki', 481012188, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (69, 'Piotr' , 'Wêgierski', 481011188, '3a')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (70, 'Marek' , 'Amsterdam', 471011188, '3a')

INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (71, 'Michal' , 'Ciasny', 390613499, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (72, 'Aldona' , 'Brum', 391113499, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (73, 'Armin' , 'Psztek', 391013499, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (74, 'Wieslaw' , 'Grywka', 391013489, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (75, 'Jakub' , 'Pineski', 391013488, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (76, 'Jakub' , 'Karry', 391012488, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (77, 'Janina' , 'Curry', 391012188, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (78, 'Jeremy' , 'Jower', 381012188, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (79, 'Piotr' , 'Mapa', 381011188, '3b')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (80, 'Marek' , 'Stó³', 371011188, '3b')

INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (81, 'Miczi' , 'Kras', 290613499, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (82, 'Dona' , 'Aarum', 291113499, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (83, 'Arin' , 'Witok', 291013499, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (84, 'Witczak' , 'Wywka', 291013489, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (85, 'Jak' , 'Tak', 291013488, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (86, 'Jan' , 'Lorry', 291012488, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (87, 'Jenina' , 'Liwry', 291012188, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (88, 'Joromy' , 'Jenes', 281012188, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (89, 'Pietr' , 'Kloin', 281011188, '3c')
INSERT [dbo].[Student] ( [StudentId], [Name], [Surname], [Pesel], [Class] ) VALUES (90, 'Mirek' , 'Kleczkiwski', 271011188, '3c')



INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (1, 2 , '1a')
INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (2, 3 , '1b')
INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (3, 4 , '1c')

INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (4, 5 , '2a')
INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (5, 6 , '2b')
INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (6, 7 , '2c')

INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (7, 8 , '3a')
INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (8, 9 , '3b')
INSERT [dbo].[ClassTeacher] ( [ClassId], [UserId], [Class] ) VALUES (9, 10 , '3c')



INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (1, 1 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (2, 2 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (3, 3 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (4, 4 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (5, 5 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (6, 6 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (7, 7 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (8, 8 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (9, 9 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (10, 10 , '3.5')

INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (11, 11 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (12, 12 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (13, 13 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (14, 14 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (15, 15 , '2.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (16, 16 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (17, 17 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (18, 18 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (19, 19 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (20, 20 , '3.5')

INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (21, 21 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (22, 22 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (23, 23 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (24, 24 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (25, 25 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (26, 26 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (27, 27 , '5.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (28, 28 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (29, 29 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (30, 30 , '3.0')

INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (31, 31 , '2.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (32, 32 , '2.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (33, 33 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (34, 34 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (35, 35 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (36, 36 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (37, 37 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (38, 38 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (39, 39 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (40, 40 , '5.0')

INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (41, 41 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (42, 42 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (43, 43 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (44, 44 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (45, 45 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (46, 46 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (47, 47 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (48, 48 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (49, 49 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (50, 50 , '4.5')

INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (51, 51 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (52, 52 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (53, 53 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (54, 54 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (55, 55 , '2.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (56, 56 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (57, 57 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (58, 58 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (59, 59 , '2.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (60, 60 , '2.5')

INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (61, 61 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (62, 62 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (63, 63 , '5.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (64, 64 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (65, 65 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (66, 66 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (67, 67 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (68, 68 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (69, 69 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (70, 70 , '2.5')

INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (71, 71 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (72, 72 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (73, 73 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (74, 74 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (75, 75 , '5.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (76, 76 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (77, 77 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (78, 78 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (79, 79 , '2.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (80, 80 , '2.0')

INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (81, 81 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (82, 82 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (83, 83 , '4.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (84, 84 , '3.0')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (85, 85 , '2.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (86, 86 , '3.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (87, 87 , '4.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (88, 88 , '5.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (89, 89 , '2.5')
INSERT [dbo].[Grades] ( [GradesStudentId], [StudentId], [Grade] ) VALUES (90, 90 , '4.5')






INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (1, 630217919 , 'Dyrektor', 'DR121518')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (2, 730606974 , 'Nauczyciel1', 'NA1111')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (3, 610520474 , 'Nauczyciel2', 'NA2222')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (4, 871105764 , 'Nauczyciel3', 'NA3333')

INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (5, 910605667 , 'Nauczyciel4', 'NA4444')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (6, 450809129 , 'Nauczyciel5', 'NA5555')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (7, 940613499 , 'Nauczyciel6', 'NA6666')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (8, 700210376 , 'Nauczyciel7', 'NA7777')

INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (9, 920421445 , 'Nauczyciel8', 'NA8888')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (10, 500410735 , 'Nauczyciel9', 'NA9999')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (11, 540410735 , 'Sekretariat1', 'SK1111')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (12, 340410335 , 'Sekretariat2', 'SK2222')

INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (13, 340410336 , 'OneAbove', 'WOZNYKROL')




INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (14, 990613499 , '1Auczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (15, 991113499 , '1Auczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (16, 991013499 , '1Auczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (17, 991013489 , '1Auczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (18, 991013488 , '1Auczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (19, 991012488 , '1Auczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (20, 991012188 , '1Auczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (21, 981012188 , '1Auczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (22, 981011188 , '1Auczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (23, 971011188 , '1Auczen', 'uczen10')



INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (24, 890613499 , '1Buczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (25, 891113499 , '1Buczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (26, 891013499 , '1Buczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (27, 891013489 , '1Buczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (28, 891013488 , '1Buczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (29, 891012488 , '1Buczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (30, 891012188 , '1Buczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (31, 881012188 , '1Buczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (32, 881011188 , '1Buczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (33, 871011188 , '1Buczen', 'uczen10')


INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (34, 990613489 , '1Cuczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (35, 991113489 , '1Cuczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (36, 991013489 , '1Cuczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (37, 991013499 , '1Cuczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (38, 991013498 , '1Cuczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (39, 991012498 , '1Cuczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (40, 991012198 , '1Cuczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (41, 981012198 , '1Cuczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (42, 981011198 , '1Cuczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (43, 971011198 , '1Cuczen', 'uczen10')


INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (44, 790613499 , '2Auczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (45, 791113499 , '2Auczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (46, 791013499 , '2Auczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (47, 791013489 , '2Auczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (48, 791013488 , '2Auczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (49, 791012488 , '2Auczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (50, 791012188 , '2Auczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (51, 781012188 , '2Auczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (52, 781011188 , '2Auczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (53, 771011188 , '2Auczen', 'uczen10')


INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (54, 690613499 , '2Buczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (55, 691113499 , '2Buczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (56, 691013499 , '2Buczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (57, 691013489 , '2Buczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (58, 691013488 , '2Buczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (59, 691012488 , '2Buczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (60, 691012188 , '2Buczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (61, 681012188 , '2Buczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (62, 681011188 , '2Buczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (63, 671011188 , '2Buczen', 'uczen10')


INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (64, 590613499 , '2Cuczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (65, 591113499 , '2Cuczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (66, 591013499 , '2Cuczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (67, 591013489 , '2Cuczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (68, 591013488 , '2Cuczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (69, 591012488 , '2Cuczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (70, 591012188 , '2Cuczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (71, 581012188 , '2Cuczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (72, 581011188 , '2Cuczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (73, 571011188 , '2Cuczen', 'uczen10')


INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (74, 490613499 , '3Auczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (75, 491113499 , '3Auczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (76, 491013499 , '3Auczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (77, 491013489 , '3Auczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (78, 491013488 , '3Auczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (79, 491012488 , '3Auczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (80, 491012188 , '3Auczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (81, 481012188 , '3Auczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (82, 481011188 , '3Auczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (83, 471011188 , '3Auczen', 'uczen10')


INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (84, 390613499 , '3Buczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (85, 391113499 , '3Buczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (86, 391013499 , '3Buczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (87, 391013489 , '3Buczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (88, 391013488 , '3Buczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (89, 391012488 , '3Buczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (90, 391012188 , '3Buczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (91, 381012188 , '3Buczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (92, 381011188 , '3Buczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (93, 371011188 , '3Buczen', 'uczen10')

INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (94, 290613499 , '3Cuczen', 'uczen1')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (95, 291113499 , '3Cuczen', 'uczen2')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (96, 291013499 , '3Cuczen', 'uczen3')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (97, 291013489 , '3Cuczen', 'uczen4')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (98, 291013488 , '3Cuczen', 'uczen5')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (99, 291012488 , '3Cuczen', 'uczen6')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (100, 291012188 , '3Cuczen', 'uczen7')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (101, 281012188 , '3Cuczen', 'uczen8')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (102, 281011188 , '3Cuczen', 'uczen9')
INSERT [dbo].[LogIns] ( [LogId], [UserPesel], [UserName], [UserPassword] ) VALUES (103, 271011188 , '3Cuczen', 'uczen10')
