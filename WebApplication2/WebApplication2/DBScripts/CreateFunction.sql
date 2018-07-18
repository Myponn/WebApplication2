---- Create Check Leap Year Function ----
/*************************************\
--20180717 -- Niphon -- Create Check Leap Year Function
--Return 0 IF number is not Leap Year
--Return 1 IF number is Leap Year
--
-- Test SQL function --
-- select case dbo.CheckLeapYear(2020) when 0 then 'is not Leap Year' else 'is Leap Year' end AS CheckIsLeapYear
--
\*************************************/
Create function [dbo].[CheckLeapYear](@number int) returns INT
BEGIN
	declare @temp1 int = 0;
	if(@number>0)
	begin
		select @temp1=@number%4 
	end
	else
		select @temp1=4
	return CASE @temp1 WHEN 0 then 1 ELSE 0 END

END
GO

---- Create Check Prime Function ----
/*************************************\
--20180717 -- Niphon -- Create Check Prime Function
--Return 0 IF number is not Prime number
--Return 1 IF number is Prime Number
--
-- Test SQL function --
-- select case dbo.CheckPrimeNumber(21) when 0 then 'is not Prime Number' else 'is Prime Number' end AS CheckIsPrime
--
\*************************************/
Create function [dbo].[CheckPrimeNumber](@number int) returns INT
BEGIN
	declare @temp1 int = 0;

	;WITH PrimeTable AS
	(
		SELECT 2 AS Value 
		UNION ALL
		SELECT PT.Value+1 AS VAlue 
		FROM PrimeTable PT
		WHERE PT.Value <= @number
	)
	SELECT @temp1=isnull(PT.Value,0)
	FROM PrimeTable PT
	WHERE NOT EXISTS
				(   SELECT 1 FROM PrimeTable pt2
					WHERE PT.Value % pt2.Value = 0 
					AND PT.Value != pt2. Value
				)
		AND PT.Value=@number
	OPTION (MAXRECURSION 0)

	return CASE @temp1 WHEN 0 then 0 ELSE 1 END

END

GO