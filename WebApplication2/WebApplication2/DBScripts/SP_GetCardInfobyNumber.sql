/**************************************************************************************\
-- 20180717 - Nipon - CREATE PROCEDURE ValidateCardInfo
\**************************************************************************************/
create procedure GetCardInfobyNumber(@CardNo varchar(16)) AS
BEGIN
	select top 1 NameOnCard,Card_Number,Expire_Date from CardTable where Card_Number=@CardNo
END
