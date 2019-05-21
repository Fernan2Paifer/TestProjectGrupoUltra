/*
Navicat SQL Server Data Transfer

Source Server         : pruebaUltra
Source Server Version : 140000
Source Host           : ultralabrds.cbengs0acekx.us-east-1.rds.amazonaws.com,1433:1433
Source Database       : Lab1
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 140000
File Encoding         : 65001

Date: 2019-05-21 11:02:29
*/


-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
DROP TABLE [dbo].[__EFMigrationsHistory]
GO
CREATE TABLE [dbo].[__EFMigrationsHistory] (
[MigrationId] nvarchar(150) NOT NULL ,
[ProductVersion] nvarchar(32) NOT NULL 
)


GO

-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.0.3-rtm-10026')
GO
GO

-- ----------------------------
-- Table structure for AspNetRoleClaims
-- ----------------------------
DROP TABLE [dbo].[AspNetRoleClaims]
GO
CREATE TABLE [dbo].[AspNetRoleClaims] (
[Id] int NOT NULL IDENTITY(1,1) ,
[ClaimType] nvarchar(MAX) NULL ,
[ClaimValue] nvarchar(MAX) NULL ,
[RoleId] nvarchar(450) NOT NULL 
)


GO

-- ----------------------------
-- Records of AspNetRoleClaims
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AspNetRoleClaims] ON
GO
SET IDENTITY_INSERT [dbo].[AspNetRoleClaims] OFF
GO

-- ----------------------------
-- Table structure for AspNetRoles
-- ----------------------------
DROP TABLE [dbo].[AspNetRoles]
GO
CREATE TABLE [dbo].[AspNetRoles] (
[Id] nvarchar(450) NOT NULL ,
[ConcurrencyStamp] nvarchar(MAX) NULL ,
[Name] nvarchar(256) NULL ,
[NormalizedName] nvarchar(256) NULL 
)


GO

-- ----------------------------
-- Records of AspNetRoles
-- ----------------------------
INSERT INTO [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'1dfd39bb-d5ed-4826-b106-9c199e023766', N'a30ae3e0-2cdb-4a24-b4af-2231e656c9e5', N'Admin', N'ADMIN')
GO
GO

-- ----------------------------
-- Table structure for AspNetUserClaims
-- ----------------------------
DROP TABLE [dbo].[AspNetUserClaims]
GO
CREATE TABLE [dbo].[AspNetUserClaims] (
[Id] int NOT NULL IDENTITY(1,1) ,
[ClaimType] nvarchar(MAX) NULL ,
[ClaimValue] nvarchar(MAX) NULL ,
[UserId] nvarchar(450) NOT NULL 
)


GO

-- ----------------------------
-- Records of AspNetUserClaims
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO

-- ----------------------------
-- Table structure for AspNetUserLogins
-- ----------------------------
DROP TABLE [dbo].[AspNetUserLogins]
GO
CREATE TABLE [dbo].[AspNetUserLogins] (
[LoginProvider] nvarchar(450) NOT NULL ,
[ProviderKey] nvarchar(450) NOT NULL ,
[ProviderDisplayName] nvarchar(MAX) NULL ,
[UserId] nvarchar(450) NOT NULL 
)


GO

-- ----------------------------
-- Records of AspNetUserLogins
-- ----------------------------
INSERT INTO [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'100760019947623952723', N'Google', N'789a030d-f800-4150-a7a0-ec22f5851f68')
GO
GO
INSERT INTO [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'107303206876864864658', N'Google', N'd655365e-f4de-4947-92ed-d51c06725e16')
GO
GO
INSERT INTO [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'110807427438492435003', N'Google', N'32474f41-6c7c-4b5d-93cf-3cdde9643933')
GO
GO
INSERT INTO [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'116764416138612489606', N'Google', N'6f371a51-a7d8-4fc0-8769-49ad71454791')
GO
GO
INSERT INTO [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'117232847902986487626', N'Google', N'adcefbb6-87b1-4273-a3a0-e19e723d8ae9')
GO
GO

-- ----------------------------
-- Table structure for AspNetUserRoles
-- ----------------------------
DROP TABLE [dbo].[AspNetUserRoles]
GO
CREATE TABLE [dbo].[AspNetUserRoles] (
[UserId] nvarchar(450) NOT NULL ,
[RoleId] nvarchar(450) NOT NULL 
)


GO

-- ----------------------------
-- Records of AspNetUserRoles
-- ----------------------------
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'adcefbb6-87b1-4273-a3a0-e19e723d8ae9', N'1dfd39bb-d5ed-4826-b106-9c199e023766')
GO
GO
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd655365e-f4de-4947-92ed-d51c06725e16', N'1dfd39bb-d5ed-4826-b106-9c199e023766')
GO
GO

-- ----------------------------
-- Table structure for AspNetUsers
-- ----------------------------
DROP TABLE [dbo].[AspNetUsers]
GO
CREATE TABLE [dbo].[AspNetUsers] (
[Id] nvarchar(450) NOT NULL ,
[AccessFailedCount] int NOT NULL ,
[ConcurrencyStamp] nvarchar(MAX) NULL ,
[Email] nvarchar(256) NULL ,
[EmailConfirmed] bit NOT NULL ,
[LockoutEnabled] bit NOT NULL ,
[LockoutEnd] datetimeoffset(7) NULL ,
[NormalizedEmail] nvarchar(256) NULL ,
[NormalizedUserName] nvarchar(256) NULL ,
[PasswordHash] nvarchar(MAX) NULL ,
[PhoneNumber] nvarchar(MAX) NULL ,
[PhoneNumberConfirmed] bit NOT NULL ,
[SecurityStamp] nvarchar(MAX) NULL ,
[TwoFactorEnabled] bit NOT NULL ,
[UserName] nvarchar(256) NULL 
)


GO

-- ----------------------------
-- Records of AspNetUsers
-- ----------------------------
INSERT INTO [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'32474f41-6c7c-4b5d-93cf-3cdde9643933', N'0', N'4213b0a4-14f1-4616-a659-aa564b654ee5', N'citasmexico60@gmail.com', N'0', N'1', null, N'CITASMEXICO60@GMAIL.COM', N'CITASMEXICO60@GMAIL.COM', null, null, N'0', N'e5ef80f1-5bfb-49e4-913b-e5207a22bc60', N'0', N'citasmexico60@gmail.com')
GO
GO
INSERT INTO [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'6f371a51-a7d8-4fc0-8769-49ad71454791', N'0', N'5bba8ba4-07ed-4e44-bf1a-9d06f2cbdb9a', N'alfonzopedro519@gmail.com', N'0', N'1', null, N'ALFONZOPEDRO519@GMAIL.COM', N'ALFONZOPEDRO519@GMAIL.COM', null, null, N'0', N'b2797d3e-26bf-40fd-b387-c02f6f4ddca4', N'0', N'alfonzopedro519@gmail.com')
GO
GO
INSERT INTO [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'789a030d-f800-4150-a7a0-ec22f5851f68', N'0', N'0c6e3cdd-c6a3-4756-9cf2-56c5538d14da', N'marcopolo.cu@gmail.com', N'0', N'1', null, N'MARCOPOLO.CU@GMAIL.COM', N'MARCOPOLO.CU@GMAIL.COM', null, null, N'0', N'69b9a060-abff-4438-8db9-70693877924f', N'0', N'marcopolo.cu@gmail.com')
GO
GO
INSERT INTO [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'adcefbb6-87b1-4273-a3a0-e19e723d8ae9', N'0', N'749fa8d1-a3b4-4490-93de-11ff4b56cbbe', N'axa.julio@grupoultra.com', N'0', N'1', null, N'AXA.JULIO@GRUPOULTRA.COM', N'AXA.JULIO@GRUPOULTRA.COM', null, null, N'0', N'ff2818c8-3c47-456e-8fbf-36244832a4d9', N'0', N'axa.julio@grupoultra.com')
GO
GO
INSERT INTO [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'd655365e-f4de-4947-92ed-d51c06725e16', N'0', N'fd3fa046-7342-4c29-82a0-5d4e72b0c622', N'fpaifer92@gmail.com', N'0', N'1', null, N'FPAIFER92@GMAIL.COM', N'FPAIFER92@GMAIL.COM', null, null, N'0', N'3028a945-56ae-4c8d-ac31-b44a05417c0c', N'0', N'fpaifer92@gmail.com')
GO
GO

-- ----------------------------
-- Table structure for AspNetUserTokens
-- ----------------------------
DROP TABLE [dbo].[AspNetUserTokens]
GO
CREATE TABLE [dbo].[AspNetUserTokens] (
[UserId] nvarchar(450) NOT NULL ,
[LoginProvider] nvarchar(450) NOT NULL ,
[Name] nvarchar(450) NOT NULL ,
[Value] nvarchar(MAX) NULL 
)


GO

-- ----------------------------
-- Records of AspNetUserTokens
-- ----------------------------

-- ----------------------------
-- Table structure for E_Ahorro
-- ----------------------------
DROP TABLE [dbo].[E_Ahorro]
GO
CREATE TABLE [dbo].[E_Ahorro] (
[idAhorro] int NOT NULL IDENTITY(1,1) ,
[Monto] int NULL ,
[fecha] date NULL ,
[Fk_trabajador] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[E_Ahorro]', RESEED, 15)
GO

-- ----------------------------
-- Records of E_Ahorro
-- ----------------------------
SET IDENTITY_INSERT [dbo].[E_Ahorro] ON
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'7', N'200', N'2019-01-16', N'11')
GO
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'8', N'300', N'2019-01-16', N'12')
GO
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'9', N'410121', N'2019-01-16', N'16')
GO
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'10', N'100', N'2019-01-16', N'17')
GO
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'11', N'700', N'2019-01-16', N'11')
GO
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'12', N'12345', N'2019-01-17', N'17')
GO
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'13', N'560', N'2019-01-17', N'17')
GO
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'14', N'567', N'2019-01-17', N'17')
GO
GO
INSERT INTO [dbo].[E_Ahorro] ([idAhorro], [Monto], [fecha], [Fk_trabajador]) VALUES (N'15', N'600', N'2019-05-21', N'11')
GO
GO
SET IDENTITY_INSERT [dbo].[E_Ahorro] OFF
GO

-- ----------------------------
-- Table structure for E_Prestamo
-- ----------------------------
DROP TABLE [dbo].[E_Prestamo]
GO
CREATE TABLE [dbo].[E_Prestamo] (
[idPrestamo] int NOT NULL IDENTITY(1,1) ,
[monto] int NULL ,
[fecha] date NULL ,
[Fk_Trabajador] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[E_Prestamo]', RESEED, 17)
GO

-- ----------------------------
-- Records of E_Prestamo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[E_Prestamo] ON
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'4', N'200', N'2019-01-16', N'11')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'5', N'100', N'2019-01-16', N'11')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'6', N'200', N'2019-01-16', N'12')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'7', N'25000', N'2019-01-16', N'11')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'8', N'150', N'2019-01-16', N'17')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'9', N'150', N'2019-01-16', N'17')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'10', N'300', N'2019-01-16', N'17')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'11', N'10000', N'2019-01-16', N'17')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'12', N'10000', N'2019-01-16', N'17')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'13', N'200', N'2019-01-16', N'11')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'14', N'25000', N'2019-01-17', N'17')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'15', N'25000', N'2019-01-17', N'17')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'16', N'25000', N'2019-01-17', N'11')
GO
GO
INSERT INTO [dbo].[E_Prestamo] ([idPrestamo], [monto], [fecha], [Fk_Trabajador]) VALUES (N'17', N'25000', N'2019-05-21', N'11')
GO
GO
SET IDENTITY_INSERT [dbo].[E_Prestamo] OFF
GO

-- ----------------------------
-- Table structure for E_Trabajador
-- ----------------------------
DROP TABLE [dbo].[E_Trabajador]
GO
CREATE TABLE [dbo].[E_Trabajador] (
[idTrabajador] int NOT NULL IDENTITY(1,1) ,
[Nombre] nvarchar(MAX) NULL ,
[Apellidos] nvarchar(MAX) NULL ,
[montoAinicial] int NULL ,
[fechaInicioRL] date NULL ,
[inscrito] bit NULL ,
[FK_User] nvarchar(450) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[E_Trabajador]', RESEED, 17)
GO

-- ----------------------------
-- Records of E_Trabajador
-- ----------------------------
SET IDENTITY_INSERT [dbo].[E_Trabajador] ON
GO
INSERT INTO [dbo].[E_Trabajador] ([idTrabajador], [Nombre], [Apellidos], [montoAinicial], [fechaInicioRL], [inscrito], [FK_User]) VALUES (N'11', N'fpaifer92@gmail.com', null, N'200', N'2017-01-16', N'1', N'd655365e-f4de-4947-92ed-d51c06725e16')
GO
GO
INSERT INTO [dbo].[E_Trabajador] ([idTrabajador], [Nombre], [Apellidos], [montoAinicial], [fechaInicioRL], [inscrito], [FK_User]) VALUES (N'12', N'alfonzopedro519@gmail.com', null, N'300', N'2018-01-16', N'1', N'6f371a51-a7d8-4fc0-8769-49ad71454791')
GO
GO
INSERT INTO [dbo].[E_Trabajador] ([idTrabajador], [Nombre], [Apellidos], [montoAinicial], [fechaInicioRL], [inscrito], [FK_User]) VALUES (N'15', N'citasmexico60@gmail.com', null, N'0', N'2019-01-16', N'0', N'32474f41-6c7c-4b5d-93cf-3cdde9643933')
GO
GO
INSERT INTO [dbo].[E_Trabajador] ([idTrabajador], [Nombre], [Apellidos], [montoAinicial], [fechaInicioRL], [inscrito], [FK_User]) VALUES (N'16', N'marcopolo.cu@gmail.com', null, N'410121', N'2019-01-16', N'1', N'789a030d-f800-4150-a7a0-ec22f5851f68')
GO
GO
INSERT INTO [dbo].[E_Trabajador] ([idTrabajador], [Nombre], [Apellidos], [montoAinicial], [fechaInicioRL], [inscrito], [FK_User]) VALUES (N'17', N'axa.julio@grupoultra.com', null, N'100', N'2017-01-17', N'1', N'adcefbb6-87b1-4273-a3a0-e19e723d8ae9')
GO
GO
SET IDENTITY_INSERT [dbo].[E_Trabajador] OFF
GO

-- ----------------------------
-- Table structure for N_CategoriaPrestamo
-- ----------------------------
DROP TABLE [dbo].[N_CategoriaPrestamo]
GO
CREATE TABLE [dbo].[N_CategoriaPrestamo] (
[idCategoria] int NOT NULL IDENTITY(1,1) ,
[antiguedad] int NULL ,
[MontoMax] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[N_CategoriaPrestamo]', RESEED, 4)
GO

-- ----------------------------
-- Records of N_CategoriaPrestamo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[N_CategoriaPrestamo] ON
GO
INSERT INTO [dbo].[N_CategoriaPrestamo] ([idCategoria], [antiguedad], [MontoMax]) VALUES (N'1', N'1', N'10000')
GO
GO
INSERT INTO [dbo].[N_CategoriaPrestamo] ([idCategoria], [antiguedad], [MontoMax]) VALUES (N'2', N'2', N'25000')
GO
GO
INSERT INTO [dbo].[N_CategoriaPrestamo] ([idCategoria], [antiguedad], [MontoMax]) VALUES (N'3', N'3', N'60000')
GO
GO
INSERT INTO [dbo].[N_CategoriaPrestamo] ([idCategoria], [antiguedad], [MontoMax]) VALUES (N'4', N'4', N'100000')
GO
GO
SET IDENTITY_INSERT [dbo].[N_CategoriaPrestamo] OFF
GO

-- ----------------------------
-- Procedure structure for SolicitarPrestamo
-- ----------------------------
DROP PROCEDURE [dbo].[SolicitarPrestamo]
GO



-- =============================================
-- Author:    
-- Create date: 
-- Description:  
-- =============================================
--[dbo].[SolicitarPrestamo]  @IdTrabajador=6,@Monto=20
CREATE PROCEDURE [dbo].[SolicitarPrestamo]
  -- Add the parameters for the stored procedure here
  @IdTrabajador INT,
  @Monto        INT
AS
  BEGIN
      DECLARE @antiguedadTrabajador INT

      SET @antiguedadTrabajador=[dbo].[Diferencia]((SELECT fechainiciorl
                                                    FROM   e_trabajador
                                                    WHERE
                                e_trabajador.idtrabajador =
                                @IdTrabajador))
      -- SET NOCOUNT ON added to prevent extra result sets from
      -- interfering with SELECT statements.
      SET nocount ON;

      -- Insert statements for procedure here
      SELECT [MontoPrestamo]=( CASE
                                 WHEN cp.montomax <= @Monto 
								 THEN cp.montomax
                                 WHEN cp.montomax > @Monto 
								 THEN @Monto
                                 WHEN ( @antiguedadTrabajador >=(SELECT Max(antiguedad)FROM [dbo].[n_categoriaprestamo]))
                                 THEN (Case	WHEN @Monto> (SELECT Max(MontoMax)FROM [dbo].[n_categoriaprestamo]) 
								            THEN (SELECT Max(MontoMax)FROM [dbo].[n_categoriaprestamo])
							            ELSE @Monto  END)
                               ELSE 0
                               END )
							
							   
      FROM   e_trabajador t
             LEFT JOIN [dbo].[n_categoriaprestamo] cp
                    ON @antiguedadTrabajador = cp.antiguedad
      WHERE  t.idtrabajador = @IdTrabajador
  --from E_Trabajador trabajador
  END  


GO

-- ----------------------------
-- Function structure for Diferencia
-- ----------------------------
DROP FUNCTION [dbo].[Diferencia]
GO


CREATE function [dbo].[Diferencia](@fecha date)
returns INT
as
begin 
 return (DATEDIFF(DAY, @fecha ,GetDate()) / 365)
end


GO

-- ----------------------------
-- Indexes structure for table __EFMigrationsHistory
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE [dbo].[__EFMigrationsHistory] ADD PRIMARY KEY ([MigrationId])
GO

-- ----------------------------
-- Indexes structure for table AspNetRoleClaims
-- ----------------------------
CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
([RoleId] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table AspNetRoleClaims
-- ----------------------------
ALTER TABLE [dbo].[AspNetRoleClaims] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table AspNetRoles
-- ----------------------------
CREATE INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
([NormalizedName] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table AspNetRoles
-- ----------------------------
ALTER TABLE [dbo].[AspNetRoles] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table AspNetUserClaims
-- ----------------------------
CREATE INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
([UserId] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table AspNetUserClaims
-- ----------------------------
ALTER TABLE [dbo].[AspNetUserClaims] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table AspNetUserLogins
-- ----------------------------
CREATE INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
([UserId] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table AspNetUserLogins
-- ----------------------------
ALTER TABLE [dbo].[AspNetUserLogins] ADD PRIMARY KEY ([LoginProvider], [ProviderKey])
GO

-- ----------------------------
-- Indexes structure for table AspNetUserRoles
-- ----------------------------
CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
([RoleId] ASC) 
GO
CREATE INDEX [IX_AspNetUserRoles_UserId] ON [dbo].[AspNetUserRoles]
([UserId] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table AspNetUserRoles
-- ----------------------------
ALTER TABLE [dbo].[AspNetUserRoles] ADD PRIMARY KEY ([UserId], [RoleId])
GO

-- ----------------------------
-- Indexes structure for table AspNetUsers
-- ----------------------------
CREATE INDEX [EmailIndex] ON [dbo].[AspNetUsers]
([NormalizedEmail] ASC) 
GO
CREATE UNIQUE INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
([NormalizedUserName] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table AspNetUsers
-- ----------------------------
ALTER TABLE [dbo].[AspNetUsers] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Triggers structure for table AspNetUsers
-- ----------------------------
DROP TRIGGER [dbo].[CreateTrabajadorByUser]
GO
CREATE TRIGGER [dbo].[CreateTrabajadorByUser]
ON [dbo].[AspNetUsers]
AFTER INSERT
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @Id nvarchar(450);
	declare @UserName nvarchar(Max);
	select @Id = Id FROM INSERTED;
    select @UserName = UserName FROM INSERTED;

	INSERT INTO dbo.E_Trabajador
	values (@UserName,null,0,GetDate(),0,@Id)
    -- Insert statements for trigger here

END



GO

-- ----------------------------
-- Indexes structure for table AspNetUserTokens
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table AspNetUserTokens
-- ----------------------------
ALTER TABLE [dbo].[AspNetUserTokens] ADD PRIMARY KEY ([UserId], [LoginProvider], [Name])
GO

-- ----------------------------
-- Indexes structure for table E_Ahorro
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table E_Ahorro
-- ----------------------------
ALTER TABLE [dbo].[E_Ahorro] ADD PRIMARY KEY ([idAhorro])
GO

-- ----------------------------
-- Indexes structure for table E_Prestamo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table E_Prestamo
-- ----------------------------
ALTER TABLE [dbo].[E_Prestamo] ADD PRIMARY KEY ([idPrestamo])
GO

-- ----------------------------
-- Indexes structure for table E_Trabajador
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table E_Trabajador
-- ----------------------------
ALTER TABLE [dbo].[E_Trabajador] ADD PRIMARY KEY ([idTrabajador])
GO

-- ----------------------------
-- Indexes structure for table N_CategoriaPrestamo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table N_CategoriaPrestamo
-- ----------------------------
ALTER TABLE [dbo].[N_CategoriaPrestamo] ADD PRIMARY KEY ([idCategoria])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[AspNetRoleClaims]
-- ----------------------------
ALTER TABLE [dbo].[AspNetRoleClaims] ADD FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[AspNetUserClaims]
-- ----------------------------
ALTER TABLE [dbo].[AspNetUserClaims] ADD FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[AspNetUserRoles]
-- ----------------------------
ALTER TABLE [dbo].[AspNetUserRoles] ADD FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[E_Ahorro]
-- ----------------------------
ALTER TABLE [dbo].[E_Ahorro] ADD FOREIGN KEY ([Fk_trabajador]) REFERENCES [dbo].[E_Trabajador] ([idTrabajador]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[E_Prestamo]
-- ----------------------------
ALTER TABLE [dbo].[E_Prestamo] ADD FOREIGN KEY ([Fk_Trabajador]) REFERENCES [dbo].[E_Trabajador] ([idTrabajador]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[E_Trabajador]
-- ----------------------------
ALTER TABLE [dbo].[E_Trabajador] ADD FOREIGN KEY ([FK_User]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO
