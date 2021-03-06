USE [master]
GO
/****** Object:  Database [Lab3DataBase]    Script Date: 08.12.2019 04:53:41 ******/
CREATE DATABASE [Lab3DataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lab3DataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Lab3DataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Lab3DataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Lab3DataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Lab3DataBase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lab3DataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lab3DataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lab3DataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lab3DataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lab3DataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lab3DataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lab3DataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Lab3DataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lab3DataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lab3DataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lab3DataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lab3DataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lab3DataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lab3DataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lab3DataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lab3DataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Lab3DataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lab3DataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lab3DataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lab3DataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lab3DataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lab3DataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Lab3DataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lab3DataBase] SET RECOVERY FULL 
GO
ALTER DATABASE [Lab3DataBase] SET  MULTI_USER 
GO
ALTER DATABASE [Lab3DataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lab3DataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lab3DataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lab3DataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Lab3DataBase] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Lab3DataBase', N'ON'
GO
ALTER DATABASE [Lab3DataBase] SET QUERY_STORE = OFF
GO
USE [Lab3DataBase]
GO
/****** Object:  Table [dbo].[ClassTeacher]    Script Date: 08.12.2019 04:53:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassTeacher](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[Class] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grades]    Script Date: 08.12.2019 04:53:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
	[GradesStudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[Grade] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[GradesStudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogIns]    Script Date: 08.12.2019 04:53:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogIns](
	[LogId] [int] IDENTITY(1,1) NOT NULL,
	[UserPesel] [int] NULL,
	[UserName] [nvarchar](30) NULL,
	[UserPassword] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[LogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 08.12.2019 04:53:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 08.12.2019 04:53:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[SalaryId] [int] IDENTITY(1,1) NOT NULL,
	[SalaryInt] [int] NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 08.12.2019 04:53:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Surname] [nvarchar](30) NULL,
	[Pesel] [int] NULL,
	[Class] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 08.12.2019 04:53:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Surname] [nvarchar](30) NULL,
	[Pesel] [int] NULL,
	[RoleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ClassTeacher] ON 

INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (1, 2, N'1a')
INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (2, 3, N'1b')
INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (3, 4, N'1c')
INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (4, 5, N'2a')
INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (5, 6, N'2b')
INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (6, 7, N'2c')
INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (7, 8, N'3a')
INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (8, 9, N'3b')
INSERT [dbo].[ClassTeacher] ([ClassId], [UserId], [Class]) VALUES (9, 10, N'3c')
SET IDENTITY_INSERT [dbo].[ClassTeacher] OFF
SET IDENTITY_INSERT [dbo].[Grades] ON 

INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (1, 1, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (2, 2, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (3, 3, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (4, 4, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (5, 5, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (6, 6, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (7, 7, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (8, 8, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (9, 9, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (10, 10, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (11, 11, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (12, 12, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (13, 13, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (14, 14, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (15, 15, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (16, 16, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (17, 17, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (18, 18, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (19, 19, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (20, 20, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (21, 21, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (22, 22, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (23, 23, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (24, 24, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (25, 25, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (26, 26, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (27, 27, N'5.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (28, 28, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (29, 29, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (30, 30, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (31, 31, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (32, 32, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (33, 33, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (34, 34, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (35, 35, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (36, 36, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (37, 37, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (38, 38, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (39, 39, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (40, 40, N'5.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (41, 41, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (42, 42, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (43, 43, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (44, 44, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (45, 45, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (46, 46, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (47, 47, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (48, 48, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (49, 49, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (50, 50, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (51, 51, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (52, 52, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (53, 53, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (54, 54, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (55, 55, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (56, 56, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (57, 57, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (58, 58, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (59, 59, N'2.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (60, 60, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (61, 61, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (62, 62, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (63, 63, N'5.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (64, 64, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (65, 65, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (66, 66, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (67, 67, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (68, 68, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (69, 69, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (70, 70, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (71, 71, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (72, 72, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (73, 73, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (74, 74, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (75, 75, N'5.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (76, 76, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (77, 77, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (78, 78, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (79, 79, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (80, 80, N'2.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (81, 81, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (82, 82, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (83, 83, N'4.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (84, 84, N'3.0')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (85, 85, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (86, 86, N'3.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (87, 87, N'4.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (88, 88, N'5.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (89, 89, N'2.5')
INSERT [dbo].[Grades] ([GradesStudentId], [StudentId], [Grade]) VALUES (90, 90, N'4.5')
SET IDENTITY_INSERT [dbo].[Grades] OFF
SET IDENTITY_INSERT [dbo].[LogIns] ON 

INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (1, 630217919, N'Dyrektor', N'DR121518')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (2, 730606974, N'Nauczyciel1', N'NA1111')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (3, 610520474, N'Nauczyciel2', N'NA2222')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (4, 871105764, N'Nauczyciel3', N'NA3333')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (5, 910605667, N'Nauczyciel4', N'NA4444')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (6, 450809129, N'Nauczyciel5', N'NA5555')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (7, 940613499, N'Nauczyciel6', N'NA6666')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (8, 700210376, N'Nauczyciel7', N'NA7777')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (9, 920421445, N'Nauczyciel8', N'NA8888')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (10, 500410735, N'Nauczyciel9', N'NA9999')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (11, 540410735, N'Sekretariat1', N'SK1111')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (12, 340410335, N'Sekretariat2', N'SK2222')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (13, 340410336, N'OneAbove', N'WOZNYKROL')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (14, 990613499, N'1Auczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (15, 991113499, N'1Auczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (16, 991013499, N'1Auczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (17, 991013489, N'1Auczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (18, 991013488, N'1Auczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (19, 991012488, N'1Auczen', N'uczen6')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (20, 991012188, N'1Auczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (21, 981012188, N'1Auczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (22, 981011188, N'1Auczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (23, 971011188, N'1Auczen', N'uczen10')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (24, 890613499, N'1Buczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (25, 891113499, N'1Buczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (26, 891013499, N'1Buczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (27, 891013489, N'1Buczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (28, 891013488, N'1Buczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (29, 891012488, N'1Buczen', N'uczen6')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (30, 891012188, N'1Buczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (31, 881012188, N'1Buczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (32, 881011188, N'1Buczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (33, 871011188, N'1Buczen', N'uczen10')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (34, 990613489, N'1Cuczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (35, 991113489, N'1Cuczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (36, 991013489, N'1Cuczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (37, 991013499, N'1Cuczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (38, 991013498, N'1Cuczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (39, 991012498, N'1Cuczen', N'uczen6')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (40, 991012198, N'1Cuczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (41, 981012198, N'1Cuczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (42, 981011198, N'1Cuczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (43, 971011198, N'1Cuczen', N'uczen10')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (44, 790613499, N'2Auczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (45, 791113499, N'2Auczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (46, 791013499, N'2Auczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (47, 791013489, N'2Auczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (48, 791013488, N'2Auczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (49, 791012488, N'2Auczen', N'uczen6')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (50, 791012188, N'2Auczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (51, 781012188, N'2Auczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (52, 781011188, N'2Auczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (53, 771011188, N'2Auczen', N'uczen10')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (54, 690613499, N'2Buczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (55, 691113499, N'2Buczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (56, 691013499, N'2Buczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (57, 691013489, N'2Buczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (58, 691013488, N'2Buczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (59, 691012488, N'2Buczen', N'uczen6')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (60, 691012188, N'2Buczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (61, 681012188, N'2Buczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (62, 681011188, N'2Buczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (63, 671011188, N'2Buczen', N'uczen10')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (64, 590613499, N'2Cuczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (65, 591113499, N'2Cuczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (66, 591013499, N'2Cuczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (67, 591013489, N'2Cuczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (68, 591013488, N'2Cuczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (69, 591012488, N'2Cuczen', N'uczen6')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (70, 591012188, N'2Cuczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (71, 581012188, N'2Cuczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (72, 581011188, N'2Cuczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (73, 571011188, N'2Cuczen', N'uczen10')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (74, 490613499, N'3Auczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (75, 491113499, N'3Auczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (76, 491013499, N'3Auczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (77, 491013489, N'3Auczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (78, 491013488, N'3Auczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (79, 491012488, N'3Auczen', N'uczen6')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (80, 491012188, N'3Auczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (81, 481012188, N'3Auczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (82, 481011188, N'3Auczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (83, 471011188, N'3Auczen', N'uczen10')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (84, 390613499, N'3Buczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (85, 391113499, N'3Buczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (86, 391013499, N'3Buczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (87, 391013489, N'3Buczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (88, 391013488, N'3Buczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (89, 391012488, N'3Buczen', N'uczen6')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (90, 391012188, N'3Buczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (91, 381012188, N'3Buczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (92, 381011188, N'3Buczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (93, 371011188, N'3Buczen', N'uczen10')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (94, 290613499, N'3Cuczen', N'uczen1')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (95, 291113499, N'3Cuczen', N'uczen2')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (96, 291013499, N'3Cuczen', N'uczen3')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (97, 291013489, N'3Cuczen', N'uczen4')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (98, 291013488, N'3Cuczen', N'uczen5')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (99, 291012488, N'3Cuczen', N'uczen6')
GO
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (100, 291012188, N'3Cuczen', N'uczen7')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (101, 281012188, N'3Cuczen', N'uczen8')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (102, 281011188, N'3Cuczen', N'uczen9')
INSERT [dbo].[LogIns] ([LogId], [UserPesel], [UserName], [UserPassword]) VALUES (103, 271011188, N'3Cuczen', N'uczen10')
SET IDENTITY_INSERT [dbo].[LogIns] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'Dyrektor')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'Nauczyciel')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (3, N'PracownikSekretariatu')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (4, N'PanWozny ')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Salary] ON 

INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (1, 10000, 1)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (2, 12000, 2)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (3, 110000, 3)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (4, 100, 4)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (5, 69420, 5)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (6, 1299, 6)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (7, 3333, 7)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (8, 6666, 8)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (9, 1700, 9)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (10, 5420, 10)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (11, 6230, 11)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (12, 69000, 12)
INSERT [dbo].[Salary] ([SalaryId], [SalaryInt], [UserId]) VALUES (13, 99999, 13)
SET IDENTITY_INSERT [dbo].[Salary] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (1, N'Michal', N'Krasny', 990613499, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (2, N'Aldona', N'Warum', 991113499, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (3, N'Armin', N'Witek', 991013499, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (4, N'Wieslaw', N'Wszywka', 991013489, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (5, N'Jakub', N'Lineski', 991013488, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (6, N'Jakub', N'Larry', 991012488, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (7, N'Janina', N'Lawry', 991012188, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (8, N'Jeremy', N'Jones', 981012188, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (9, N'Piotr', N'Klein', 981011188, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (10, N'Marek', N'Kleczkowski', 971011188, N'1a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (11, N'Marek', N'Krasny', 890613499, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (12, N'Ania', N'Warum', 891113499, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (13, N'Asia', N'Witek', 891013499, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (14, N'Witolda', N'Wszywka', 891013489, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (15, N'John', N'Lineski', 891013488, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (16, N'Jerry', N'Larry', 891012488, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (17, N'Jasny', N'Lawry', 891012188, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (18, N'Jensen', N'Jones', 881012188, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (19, N'Pawel', N'Klein', 881011188, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (20, N'Maria', N'Kleczkowska', 871011188, N'1b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (21, N'Michal', N'Kewski', 990613489, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (22, N'Aldona', N'Wilska', 991113489, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (23, N'Armin', N'Wielki', 991013489, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (24, N'Wieslaw', N'Wojewoda', 991013499, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (25, N'Jakub', N'Lirew', 991013498, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (26, N'Jakub', N'Kiel', 991012498, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (27, N'Janina', N'Opania', 991012198, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (28, N'Jeremy', N'Tym', 981012198, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (29, N'Piotr', N'Milos', 981011198, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (30, N'Marek', N'Kisne', 971011198, N'1c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (31, N'Adam', N'Krasny', 790613499, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (32, N'Alex', N'Warum', 791113499, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (33, N'Ambrozy', N'Witek', 791013499, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (34, N'Witold', N'Wszywka', 791013489, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (35, N'Kamil', N'Lineski', 791013488, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (36, N'Kevin', N'Larry', 791012488, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (37, N'Patryk', N'Lawry', 791012188, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (38, N'Karol', N'Jones', 781012188, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (39, N'Mateusz', N'Klein', 781011188, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (40, N'Ada', N'Kleczkowska', 771011188, N'2a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (41, N'Michal', N'Chrobry', 690613499, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (42, N'Aldona', N'Sobieski', 691113499, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (43, N'Armin', N'August', 691013499, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (44, N'Wieslaw', N'Chodkiewicz', 691013489, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (45, N'Jakub', N'Batory', 691013488, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (46, N'Jakub', N'Car', 691012488, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (47, N'Janina', N'Mickiewicz', 691012188, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (48, N'Jeremy', N'Słowacki', 681012188, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (49, N'Piotr', N'Norwid', 681011188, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (50, N'Marek', N'Anonim', 671011188, N'2b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (51, N'Mikołaj', N'Krasny', 590613499, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (52, N'Marianna', N'Warum', 591113499, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (53, N'Alojzy', N'Witek', 591013499, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (54, N'Witold', N'Wierzbicki', 591013489, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (55, N'Jimmy', N'Lineski', 591013488, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (56, N'Johnatan', N'Larry', 591012488, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (57, N'Dio', N'Lawry', 591012188, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (58, N'Dariusz', N'Jones', 581012188, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (59, N'Joseph', N'Klein', 581011188, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (60, N'Armani', N'Kleczkowski', 571011188, N'2c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (61, N'Michal', N'Krzysiak', 490613499, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (62, N'Aldona', N'Chorąży', 491113499, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (63, N'Armin', N'Żółć', 491013499, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (64, N'Wieslaw', N'Polski', 491013489, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (65, N'Jakub', N'Niemiecki', 491013488, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (66, N'Jakub', N'Rosyjski', 491012488, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (67, N'Janina', N'Litewski', 491012188, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (68, N'Jeremy', N'Nordycki', 481012188, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (69, N'Piotr', N'Węgierski', 481011188, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (70, N'Marek', N'Amsterdam', 471011188, N'3a')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (71, N'Michal', N'Ciasny', 390613499, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (72, N'Aldona', N'Brum', 391113499, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (73, N'Armin', N'Psztek', 391013499, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (74, N'Wieslaw', N'Grywka', 391013489, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (75, N'Jakub', N'Pineski', 391013488, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (76, N'Jakub', N'Karry', 391012488, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (77, N'Janina', N'Curry', 391012188, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (78, N'Jeremy', N'Jower', 381012188, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (79, N'Piotr', N'Mapa', 381011188, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (80, N'Marek', N'Stół', 371011188, N'3b')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (81, N'Miczi', N'Kras', 290613499, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (82, N'Dona', N'Aarum', 291113499, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (83, N'Arin', N'Witok', 291013499, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (84, N'Witczak', N'Wywka', 291013489, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (85, N'Jak', N'Tak', 291013488, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (86, N'Jan', N'Lorry', 291012488, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (87, N'Jenina', N'Liwry', 291012188, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (88, N'Joromy', N'Jenes', 281012188, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (89, N'Pietr', N'Kloin', 281011188, N'3c')
INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Pesel], [Class]) VALUES (90, N'Mirek', N'Kleczkiwski', 271011188, N'3c')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Worker] ON 

INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (1, N'Adam', N'Miskowiak', 630217919, 1)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (2, N'Milowicz', N'Karolak', 730606974, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (3, N'Dio', N'ApproachingMe', 610520474, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (4, N'Kargul', N'Bareja', 871105764, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (5, N'Ricardo', N'Milos', 910605667, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (6, N'Krystian', N'Karczynski', 450809129, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (7, N'General', N'Kenobi', 940613499, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (8, N'Enrique', N'Eglesias', 700210376, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (9, N'Pepe', N'SadFrog', 920421445, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (10, N'NoIPan', N'PawelOczywiscie', 500410735, 2)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (11, N'HackerMan', N'Witos', 540410735, 3)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (12, N'Marylin', N'Monroe', 340410335, 3)
INSERT [dbo].[Worker] ([UserId], [Name], [Surname], [Pesel], [RoleId]) VALUES (13, N'Leon', N'Zawodowiec', 340410336, 4)
SET IDENTITY_INSERT [dbo].[Worker] OFF
ALTER TABLE [dbo].[ClassTeacher]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Worker] ([UserId])
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Worker] ([UserId])
GO
ALTER TABLE [dbo].[Worker]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
USE [master]
GO
ALTER DATABASE [Lab3DataBase] SET  READ_WRITE 
GO
