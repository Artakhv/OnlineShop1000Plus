﻿using System.Collections.Generic;
using OnlineShop.Common;
using OnlineShop.Common.DbModels;

namespace OnlineShop.Dal.Repositories.Interfaces
{
    public interface ICartManagementDAL
    {
        IEnumerable<Cart> ViewCart(int userId);
        IEnumerable<Cart> AddItemToCart(int userId, int itemId);
        IEnumerable<Cart> RemoveItemFromCart(int userId, int itemId);
        bool IsInCart(int userId, int itemId);
        Orders PlaceOrder(int cartId);
        void CancelOrder(int orderId);
        IEnumerable<Orders> OrderHistory(int userId);
        Orders GetOrderById(int id);
    }
}
