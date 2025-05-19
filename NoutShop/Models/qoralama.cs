//public List<Products> Products { get; set; } = new List<Products>();
//public string Create(Products products)
//{
//    Products.Add(products);

//    return "product qoshildi";
//}

//public bool Delete(int idproduct)
//{
//    var product = Products.FirstOrDefault(x => x.Id == idproduct);

//    if (product != null)
//    {
//        Products.Remove(product);
//        return true;
//    }
//    return false;
//}
//public IEnumerable<Products> GetAll()
//{
//    return Products;
//}

//public Products GetByID(int idproduct)
//{
//    var products = Products.FirstOrDefault(x => x.Id == idproduct);

//    return products;
//}

//public Products Update(Products products)
//{
//    var data = Products.FirstOrDefault(x => x.Id == products.Id);
//    if (data != null)
//    {
//        data.Name = products.Name;
//        data.Price = products.Price;
//        data.Category = products.Category;
//        data.CreatedTime = products.CreatedTime;
//        return data;

//    }
//    return null;
//}

//public Products UpdateproductPrice(Products product)
//{
//    var data = Products.FirstOrDefault(x => x.Id == product.Id);
//    if (data != null)
//    {
//        data.Price = product.Price;
//        return data;
//    }
//    return null;
//}
