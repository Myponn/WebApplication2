/**************************************************************************************\
-- 20180717 - Nipon - CREATE PROCEDURE CheckCardExists
\**************************************************************************************/
create procedure CheckCardExists(@Name varchar(50),@CardNo varchar(16),@ExpDate varchar(6)) AS
BEGIN
	declare @cnt integer
	if(@Name is not null and @CardNo is not null and @ExpDate is not null)
	begin
		select @cnt=Count('X') from CardTable Where NameOnCard=@Name and Card_Number=@CardNo and Expire_Date=@ExpDate
		if(@cnt=1)
		begin
			select result=1
		end
		else
			select result=0
	end
	else
		select result=0
END
