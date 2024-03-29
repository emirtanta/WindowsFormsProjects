USE [WinFormsHospitalManagementDB]
GO
/****** Object:  Table [dbo].[Diagnosises]    Script Date: 2.01.2022 15:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnosises](
	[DiagnosisId] [int] NOT NULL,
	[PatientId] [int] NOT NULL,
	[PatientName] [nvarchar](50) NOT NULL,
	[Symptoms] [nvarchar](80) NOT NULL,
	[Diagnosis] [nvarchar](50) NOT NULL,
	[Medicines] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Diagnosises] PRIMARY KEY CLUSTERED 
(
	[DiagnosisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 2.01.2022 15:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorId] [int] NOT NULL,
	[DoctorName] [nvarchar](50) NOT NULL,
	[DoctorExperience] [int] NOT NULL,
	[DoctorPassword] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 2.01.2022 15:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[PatientId] [int] NOT NULL,
	[PatientName] [nvarchar](50) NOT NULL,
	[PatientAddress] [nvarchar](50) NOT NULL,
	[PatientPhone] [nvarchar](50) NOT NULL,
	[PatientAge] [int] NOT NULL,
	[PatientGender] [nvarchar](10) NULL,
	[PatientBlood] [nvarchar](10) NULL,
	[PatientDisease] [nvarchar](80) NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Diagnosises] ([DiagnosisId], [PatientId], [PatientName], [Symptoms], [Diagnosis], [Medicines]) VALUES (1, 101, N'santashh', N'aaa', N'ff', N'dd')
INSERT [dbo].[Doctors] ([DoctorId], [DoctorName], [DoctorExperience], [DoctorPassword]) VALUES (101, N'kumar', 15, N'2325')
INSERT [dbo].[Patients] ([PatientId], [PatientName], [PatientAddress], [PatientPhone], [PatientAge], [PatientGender], [PatientBlood], [PatientDisease]) VALUES (101, N'santashh', N'mumbaii', N'6575641', 22, N'Bayan', N'AB-', N'var')
