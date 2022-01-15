USE [WinformEmployeeManagementDB]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 15.01.2022 14:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeId] [varchar](10) NOT NULL,
	[EmployeeName] [varchar](50) NOT NULL,
	[EmployeeAddress] [varchar](50) NOT NULL,
	[EmployeePosition] [varchar](50) NOT NULL,
	[EmployeeBirtDate] [varchar](50) NOT NULL,
	[EmployeePhone] [varchar](10) NOT NULL,
	[EmployeeEducation] [varchar](50) NOT NULL,
	[EmployeeGender] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Employees] ([EmployeId], [EmployeeName], [EmployeeAddress], [EmployeePosition], [EmployeeBirtDate], [EmployeePhone], [EmployeeEducation], [EmployeeGender]) VALUES (N'XYZ0011', N'emir', N'test', N'Junior Develooper', N'1.01.2022', N'2451234569', N'MCom', N'Erkek')
INSERT [dbo].[Employees] ([EmployeId], [EmployeeName], [EmployeeAddress], [EmployeePosition], [EmployeeBirtDate], [EmployeePhone], [EmployeeEducation], [EmployeeGender]) VALUES (N'XYZ0012', N'emre', N'test', N'Senior Develooper', N'15.02.1990 00:00:00', N'2451234568', N'BTech', N'Erkek')
INSERT [dbo].[Employees] ([EmployeId], [EmployeeName], [EmployeeAddress], [EmployeePosition], [EmployeeBirtDate], [EmployeePhone], [EmployeeEducation], [EmployeeGender]) VALUES (N'XYZ0013', N'can', N'test', N'Yönetici', N'15.02.1990 00:00:00', N'2451234569', N'MBA', N'Erkek')
INSERT [dbo].[Employees] ([EmployeId], [EmployeeName], [EmployeeAddress], [EmployeePosition], [EmployeeBirtDate], [EmployeePhone], [EmployeeEducation], [EmployeeGender]) VALUES (N'XYZ0014', N'cem', N'test', N'Junior Develooper', N'15.01.1990 00:00:00', N'2451234565', N'BBA', N'Erkek')
INSERT [dbo].[Employees] ([EmployeId], [EmployeeName], [EmployeeAddress], [EmployeePosition], [EmployeeBirtDate], [EmployeePhone], [EmployeeEducation], [EmployeeGender]) VALUES (N'XYZ0015', N'deren', N'test', N'Yönetici', N'15.01.1990 00:00:00', N'2451234563', N'MBA', N'Erkek')
