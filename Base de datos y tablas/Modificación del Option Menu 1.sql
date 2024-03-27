Select 
		--A.[IdItem]
		 A.[ItemName]
		,A.[Stock]
		--,A.[IdTypePrioritary]
		,B.[TypePrioritaryName] AS Type_Prioritary
		--,A.[IdTypeStock]
		,C.[TypeStockName] AS Type_Stock
		,A.[PurchesDate]
		,A.[ExpirationDate]
		--,A.[Active]
FROM [dbo].[Item] A
INNER JOIN [dbo].[CatTypePrioritary] B
ON A.[IdTypePrioritary] = B.[IdTypePrioritary]
INNER JOIN [dbo].[CatTypeStock] C
ON A.[IdTypeStock] = C.[IdTypeStock]
WHERE A.[Active] = 1

SELECT * FROM Item
SELECT * FROM CatTypePrioritary
SELECT * FROM CatTypeStock