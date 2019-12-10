﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Bll.Repositories.Interfaces;
using OnlineShop.Common;
using OnlineShop.Dal;

namespace OnlineShop.Bll.Repositories.Implementation
{
    public class CartManagementBLL : ICartManagementBLL
    {
        private readonly OnlineShopDAL _onlineShopDAL;
        public CartManagementBLL()
        {
            _onlineShopDAL = new OnlineShopDAL(new DbContextOptions<OnlineShopAlphaContext>());
        }

        public IEnumerable<Cart> ViewCart(int userId)
        {
            return _onlineShopDAL.CartManagementDAL.ViewCart(userId);
        }

        public IEnumerable<Cart> AddItemToCart(int userId, int itemId)
        {
            return _onlineShopDAL.CartManagementDAL.AddItemToCart(userId, itemId);
        }

        public IEnumerable<Cart> RemoveItemFromCart(int userId, int itemId)
        {
            return _onlineShopDAL.CartManagementDAL.RemoveItemFromCart(userId, itemId);
        }

        public bool IsInCart(int userId, int itemId)
        {
            return _onlineShopDAL.CartManagementDAL.IsInCart(userId, itemId);
        }
    }
}
