CREATE FUNCTION [dbo].ufn_CashInUsersGames(
    @gameName NVARCHAR(MAX)
)
RETURNS DEC(10,2)
AS 
BEGIN

	DECLARE @result DEC(10, 2)
	
	SET @result = (SELECT SUM(usrgame.[Cash]) FROM 
		(SELECT *, Row_Number() OVER(ORDER BY [Cash] DESC) AS RowNumber 
		FROM [dbo].[UsersGames]) usrgame
			INNER JOIN (SELECT * FROM [dbo].[Games] WHERE [Name] = @gameName) AS game ON usrgame.[Id] = game.[Id]
	WHERE usrgame.RowNumber % 2 = 1)

    RETURN @result;
END;

SELECT [dbo].ufn_CashInUsersGames('Love in a mist') AS [SumCash]