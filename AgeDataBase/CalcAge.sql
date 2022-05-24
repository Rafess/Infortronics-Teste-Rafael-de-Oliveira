USE AgeDataBase
GO

DECLARE		@nasc AS VARCHAR(11) = '17/07/2008',
			@today AS DATE = GETDATE();
INSERT INTO age_tbl (birth)
VALUES (@nasc);
 
SELECT FLOOR(DATEDIFF(DAY, CONVERT(DATE, @nasc, 103), @today) / 365.23076923074) as idade
FROM age_tbl
GO
