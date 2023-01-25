CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [brand] NTEXT NULL, 
    [model] NTEXT NULL, 
    [year] NCHAR(4) NULL, 
    [techyear] NCHAR(4) NULL, 
    [owner] NTEXT NULL, 
    [fineamount] BIGINT NULL
)
