USE [master]
GO
/****** Object:  Database [ProjectA]    Script Date: 5/3/2019 10:08:46 AM ******/
CREATE DATABASE [ProjectA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectA', FILENAME = N'E:\SQL\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProjectA.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProjectA_log', FILENAME = N'E:\SQL\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProjectA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProjectA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectA] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectA] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjectA] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProjectA] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjectA', N'ON'
GO
USE [ProjectA]
GO
/****** Object:  Table [dbo].[Advisor]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advisor](
	[Id] [int] NOT NULL,
	[Designation] [int] NOT NULL,
	[Salary] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evaluation]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evaluation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[TotalMarks] [int] NOT NULL,
	[TotalWeightage] [int] NOT NULL,
 CONSTRAINT [PK_Evaluation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created_On] [date] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupEvaluation]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupEvaluation](
	[GroupId] [int] NOT NULL,
	[EvaluationId] [int] NOT NULL,
	[ObtainedMarks] [int] NOT NULL,
	[EvaluationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupEvaluation] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[EvaluationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupProject]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProject](
	[ProjectId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupProject] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupStudent]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupStudent](
	[GroupId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupStudent] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lookup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NULL,
	[Contact] [varchar](20) NULL,
	[Email] [varchar](30) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectAdvisor]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAdvisor](
	[AdvisorId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[AdvisorRole] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProjectAdvisor] PRIMARY KEY CLUSTERED 
(
	[AdvisorId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/3/2019 10:08:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[RegistrationNo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (1, 7, CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (2, 8, CAST(24 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (3, 7, CAST(123 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (4, 10, CAST(2789 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (5, 9, CAST(687 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (7, 9, CAST(56000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (8, 9, CAST(2890887 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Evaluation] ON 

INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (2, N'Befor Mid Evaluation', 20, 2)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (5, N'after mid', 10, 76)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (6, N'post mids', 45, 9)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (7, N'proposal', 10, 10)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (8, N'Viva Evaluation', 10, 5)
SET IDENTITY_INSERT [dbo].[Evaluation] OFF
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (38, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (39, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (40, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (41, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (42, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (43, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (44, CAST(N'2019-03-28' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (45, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (46, CAST(N'2019-03-11' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (47, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (48, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (49, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (50, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (51, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (52, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (53, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (54, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (55, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (56, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (57, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (58, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (59, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (60, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (61, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (62, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (64, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (65, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (66, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (67, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (68, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (69, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (70, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (71, CAST(N'2019-03-31' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (72, CAST(N'2019-04-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (73, CAST(N'2019-04-26' AS Date))
SET IDENTITY_INSERT [dbo].[Group] OFF
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (39, 7, 2, CAST(N'2019-05-03 09:59:26.867' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (40, 7, 10, CAST(N'2019-05-03 09:59:26.867' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (73, 7, 9, CAST(N'2019-04-26 09:53:03.443' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (4, 38, CAST(N'2019-03-05 11:46:04.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (38, 71, 4, CAST(N'2019-03-28 18:44:00.733' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (38, 72, 4, CAST(N'2019-03-28 18:44:00.733' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (38, 73, 4, CAST(N'2019-03-28 18:44:00.733' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (38, 75, 4, CAST(N'2019-03-28 18:44:00.733' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (39, 42, 3, CAST(N'2019-03-30 19:02:20.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (39, 43, 3, CAST(N'2019-03-30 19:02:20.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (39, 44, 3, CAST(N'2019-03-30 19:02:20.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (43, 55, 3, CAST(N'2019-03-28 19:07:56.653' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (43, 56, 3, CAST(N'2019-03-28 19:07:56.653' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (43, 57, 3, CAST(N'2019-03-28 19:07:56.653' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (43, 58, 3, CAST(N'2019-03-28 19:07:56.653' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (48, 53, 3, CAST(N'2019-03-31 09:17:44.420' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (48, 54, 3, CAST(N'2019-03-31 09:17:44.420' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (48, 55, 3, CAST(N'2019-03-31 09:17:44.420' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (48, 56, 3, CAST(N'2019-03-31 09:17:44.420' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (69, 47, 3, CAST(N'2019-03-31 15:10:01.090' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (69, 48, 3, CAST(N'2019-03-31 15:10:01.090' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (69, 49, 3, CAST(N'2019-03-31 15:10:01.090' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (69, 50, 3, CAST(N'2019-03-31 15:10:01.090' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (71, 45, 3, CAST(N'2019-03-31 15:12:46.900' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (71, 46, 3, CAST(N'2019-03-31 15:12:46.900' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (71, 47, 3, CAST(N'2019-03-31 15:12:46.900' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (71, 48, 3, CAST(N'2019-03-31 15:12:46.900' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (73, 78, 4, CAST(N'2019-04-26 09:51:49.500' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (73, 79, 4, CAST(N'2019-04-26 09:51:49.500' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (73, 80, 4, CAST(N'2019-04-26 09:51:49.500' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (73, 81, 4, CAST(N'2019-04-26 09:51:49.500' AS DateTime))
SET IDENTITY_INSERT [dbo].[Lookup] ON 

INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (1, N'Male', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (2, N'Female', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (3, N'Active', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (4, N'InActive', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (6, N'Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (7, N'Associate Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (8, N'Assisstant Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (9, N'Lecturer', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (10, N'Industry Professional', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (11, N'Main Advisor', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (12, N'Co-Advisror', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (14, N'Industry Advisor', N'ADVISOR_ROLE')
SET IDENTITY_INSERT [dbo].[Lookup] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (37, N'Mohid ', N'Bin Nauman', N'090078601', N'bubu@gmail.com', CAST(N'2017-01-21 20:45:58.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (40, N'Tabi', N'rasheed Ahmad', N'8739', N'tayyaba@gmail.com', CAST(N'2019-03-11 20:53:40.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (41, N'irfan', N'rasheed ahmad', N'03224267689', N'fani@gmail.com', CAST(N'2019-03-11 21:13:29.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (42, N'Ramzan', N'Rasheed', N'03110404467', N'ramzan@gmail.com', CAST(N'2019-03-05 09:14:34.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (43, N'Irfan', N'Rasheed', N'03224267689', N'fanibandar@gmail,com', CAST(N'2019-01-02 09:14:34.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (44, N'Tayyaba', N'Rasheed', N'03154717937', N'tabi@gmail.com', CAST(N'2019-01-01 09:23:25.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (45, N'Aqsa', N'Arshad', N'03224717937', N'aqsa@gmail.com', CAST(N'2017-12-30 09:23:25.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (46, N'Amina', N'Javed', N'03200478008', N'amina@gmail.com', CAST(N'2017-03-09 09:23:25.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (47, N'Amina', N'Irshad', N'03164258187', N'amie@gmail.com', CAST(N'2017-07-15 09:23:25.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (48, N'Suleman', N'Rashid', N'374', N'mano@gmail.com', CAST(N'2019-03-01 11:02:39.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (49, N'Sultan', N'Rashid', N'873492', N'shani@gmail.com', CAST(N'2019-02-01 11:02:39.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (50, N'Saad', N'Rashid', N'873429', N'saadi@gmail.com', CAST(N'2019-02-08 11:02:39.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (51, N'Shibra', N'Rashid', N'6394', N'shibra@gmail.com', CAST(N'2019-02-20 11:02:39.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (52, N'Anas', N'arshad', N'02344650621', N'ans@gmail.com', CAST(N'2019-03-15 11:19:22.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (53, N'arsalan', N'murad', N'982734', N'arsi@gmail.com', CAST(N'2019-03-15 11:19:22.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (54, N'Aqsa', N'Mansha', N'82734', N'aqsamansha@gmail.com', CAST(N'2019-03-15 12:53:40.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (55, N'hifza', N'mansha', N'8937', N'hifza@gmail.com', CAST(N'2019-03-15 12:53:40.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (56, N'abdul', N'rehman', N'98273', N'honey@gmail.com', CAST(N'2019-03-15 12:53:40.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (57, N'moon', N'mansha', N'82739', N'mani@gmail.com', CAST(N'2019-03-15 12:53:40.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (58, N'ali', N'hammad', N'7826348', N'ali@gmail.com', CAST(N'2019-03-04 22:04:08.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (59, N'Junaid', N'Zulfiqar', N'87301', N'juni@gmail.com', CAST(N'2019-03-17 22:04:08.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (60, N'Babar', N'azam', N'7639', N'babar@gmail.com', CAST(N'2019-03-04 22:04:08.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (64, N'murtaza', N'rasheed', N'17298', N'jhsd', CAST(N'2019-03-04 16:59:55.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (65, N'murtaza', N'rasheed', N'090078601', N'mu@gmail.com', CAST(N'2019-03-11 17:07:14.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (66, N'tabeer', N'sohail', N'0987', N'tabi@gmail.com', CAST(N'2019-03-10 17:10:56.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (68, N'tania', N'sohail', N'03154717937', N'tabi@gmail.com', CAST(N'2019-03-18 17:23:33.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (69, N'shazia', N'shoaib', N'03234670891', N'shazi@gmail.com', CAST(N'2019-03-13 17:25:39.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (70, N'iqbal', N'hassan', N'03509876301', N'jah@gmail.com', CAST(N'2019-03-28 17:28:16.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (71, N'tabo', N'rasheed', N'03124717937', N't@gmail.com', CAST(N'2019-03-28 17:39:45.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (72, N'javed', N'iqbal', N'03256789098', N'jashkdj', CAST(N'2019-03-28 17:39:45.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (73, N'permisha', N'tahir', N'03224789067', N'per*iko93', CAST(N'2019-03-28 17:56:55.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (75, N'kalsoom', N'nawaz', N'03234689076', N'kalsoomnawaz@gmail.com', CAST(N'2019-03-04 18:10:46.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (77, N'sajawal', N'arshad', N'03224717937', N'saji@gmail.com', CAST(N'2019-03-13 13:26:01.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (78, N'Nazish', N'iqbal', N'03110478008', N'nazi@gmail.com', CAST(N'2019-04-07 09:19:03.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (79, N'junaid', N'zulfikar', N'03200478008', N'juni@gmail.com', CAST(N'2019-04-08 09:34:31.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (80, N'Rao', N'Anwar', N'03234650621', N'rao@gmail.com', CAST(N'2019-04-08 09:34:31.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (81, N'Ahmad', N'usman', N'03110404467', N'ah@gmail.com', CAST(N'2019-04-08 09:34:31.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (1, N'create using C++', N'Database Project')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (4, N'Its a mini Desktop application for hospital', N'School Management System')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (6, N'Its a mini porject for final year students', N'FYP Management')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (8, N'FYP Using Deep Learning', N'Urdu Chat Bot')
SET IDENTITY_INSERT [dbo].[Project] OFF
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (3, 1, 11, CAST(N'2019-03-28 14:00:59.170' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (3, 4, 12, CAST(N'2019-03-28 13:56:45.847' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (5, 4, 14, CAST(N'2019-03-12 13:35:53.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (41, N'2014-cem-1')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (42, N'2016-ME-2')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (43, N'2013-cem-2')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (44, N'2016-cs-369')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (45, N'2016-it-120')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (46, N'2016-cs-360')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (47, N'2016-cs-366')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (48, N'2016-cs-3')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (49, N'2016-me-4')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (50, N'2016-me-5')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (51, N'2012-cem-9')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (52, N'2016-ce-1')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (53, N'2016-ce-2')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (54, N'2013-civ-19')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (55, N'2009-MEC-90')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (56, N'2011-ibm-2')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (57, N'2010-pet-3')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (58, N'2016-civ-90')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (59, N'2016-civ-91')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (60, N'2016-civ-92')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (64, N'2019-cs-445')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (65, N'2016-cs-456')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (66, N'2016-cs-376')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (68, N'2019-cs-768')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (69, N'2016-cs-3699')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (70, N'2018-cs-899')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (71, N'2019-cs-567')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (72, N'2019-cs-534')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (73, N'2018-cs-678')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (75, N'2013-me-23')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (77, N'2006-cs-98')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (78, N'2016-cs-456')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (79, N'2016-ME-90')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (80, N'2016-ME-91')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (81, N'2016-ME-92')
ALTER TABLE [dbo].[Advisor]  WITH CHECK ADD  CONSTRAINT [FK_Advisor_Lookup] FOREIGN KEY([Designation])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Advisor] CHECK CONSTRAINT [FK_Advisor_Lookup]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Evaluation] FOREIGN KEY([EvaluationId])
REFERENCES [dbo].[Evaluation] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Evaluation]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Project]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_GroupStudents_Lookup] FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_GroupStudents_Lookup]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Group]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Student]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Lookup] FOREIGN KEY([Gender])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Lookup] FOREIGN KEY([AdvisorRole])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Project]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTeachers_Teacher] FOREIGN KEY([AdvisorId])
REFERENCES [dbo].[Advisor] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectTeachers_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([Id])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
USE [master]
GO
ALTER DATABASE [ProjectA] SET  READ_WRITE 
GO
