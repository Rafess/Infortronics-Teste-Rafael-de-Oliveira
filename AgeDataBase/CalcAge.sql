USE AgeDataBase
GO
CREATE TABLE birth_tbl
(
	[birth] VARCHAR(11) NOT NULL
    
)
GO

DECLARE		@nasc AS VARCHAR(11) = '17/07/2008',
			@today AS DATE = GETDATE();
--INSERT INTO birth_tbl.birth
-- VALUES (@nasc);
 
 -- @nasc ou birth?
SELECT FLOOR(DATEDIFF(DAY, CONVERT(DATE, @nasc), @today) / 365.23076923074) as idade
FROM birth_tbl
-- todo tentar criar a tablea age_db
GO
