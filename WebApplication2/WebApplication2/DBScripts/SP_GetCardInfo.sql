
/**************************************************************************************\
-- 20180717 - Nipon - CREATE PROCEDURE [GetCardInfo]
\**************************************************************************************/
create procedure [dbo].[GetCardInfo](@Name varchar(50),@CardNo varchar(16),@expDate varchar(6)) AS
BEGIN
	select [NameOnCard],[CardNumber],[ExpiryDate] 
	from CardTable 
	where [CardNumber]=@CardNo and [NameOnCard]=@Name and [ExpiryDate]=@expDate
END

GO

/**************************************************************************************\
-- 20180717 - Nipon - CREATE PROCEDURE [GetCardInfobyNumber]
\**************************************************************************************/
create procedure [dbo].[GetCardInfobyNumber](@CardNo varchar(16)) AS
BEGIN
	select [NameOnCard],[CardNumber],[ExpiryDate] from CardTable where [CardNumber]=@CardNo
END

GO