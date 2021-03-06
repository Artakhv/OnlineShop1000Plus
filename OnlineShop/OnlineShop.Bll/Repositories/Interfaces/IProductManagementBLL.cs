﻿using System.Collections.Generic;
using OnlineShop.Common.DbModels;

namespace OnlineShop.Bll.Repositories.Interfaces
{
    public interface IProductManagementBLL
    {
        //Create
        Products AddProduct(Products product);

        //Read
        IEnumerable<Products> AllProducts { get; }
        Products GetProductById(int id);
        Products  GetProductByName(string name);
        IEnumerable<Products> GetProductsByPage(int count, int page);
        IEnumerable<Products> GetProductsByPageInCategory(int count, int page, int categoryId);

        //Update
        Products UpdateProduct(Products oldProduct, Products newProduct);

        //Delete
        void RemoveProduct(params Products[] products);
        void RemoveProductById(int id);
    }
}
