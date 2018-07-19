---- Create Table ----
CREATE TABLE [dbo].[CardTable](
	[NameOnCard]  [varchar](50) NOT NULL,
	[CardNumber] [varchar](16) NOT NULL,
	[ExpiryDate] [varchar](6) NOT NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [UNIX_CardTable] ON [dbo].[CardTable]
(
	[NameOnCard] ASC,
	[CardNumber] ASC,
	[ExpiryDate] ASC
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_CardTable] ON [dbo].[CardTable]
(
	[NameOnCard] ASC
) ON [PRIMARY]
GO

---- Insert Data ----
insert into CardTable values('Name LastName','4567890123456789','012020')
insert into CardTable values('Name LastName','4567890123456790','012021')
insert into CardTable values('Name LastName','4567890123456791','012022')
insert into CardTable values('Name LastName','4567890123456792','012023')
GO
insert into CardTable values('Name LastName','3456789012345678','012099')
insert into CardTable values('Name LastName','3456789012345679','022099')
insert into CardTable values('Name LastName','3456789012345680','032099')
insert into CardTable values('Name LastName','3456789012345681','042099')
GO
insert into CardTable values('Name LastName','5678901234567890','012021')
insert into CardTable values('Name LastName','5678901234567891','012023')
insert into CardTable values('Name LastName','5678901234567892','012017')
insert into CardTable values('Name LastName','5678901234567893','012020')
GO
insert into CardTable values('Name LastName','345678901234567','012099')
insert into CardTable values('Name LastName','345678901234568','012099')
insert into CardTable values('Name LastName','345678901234569','012099')
insert into CardTable values('Name LastName','345678901234570','012099')
GO
