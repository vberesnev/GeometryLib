SELECT [Products].product,
	   [Categories].category
FROM [Products] LEFT JOIN [Categories] 
				on [Products].categoryId = [Categories].Id
