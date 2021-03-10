Select p.Name as 'Product Name', c.Name as 'Category Name'
From Product p
left Join Product_Category pc On pc.ProductId = p.Id
left Join Category c on c.Id = pc.CategoryId
