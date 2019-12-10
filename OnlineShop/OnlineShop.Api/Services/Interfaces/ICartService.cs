﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Common;

namespace OnlineShop.Api.Services.Interfaces
{
    public interface ICartService
    {
        IEnumerable<Cart> ViewCart(int userId);
        IEnumerable<Cart> AddItemToCart(int userId, int itemId);
        IEnumerable<Cart> RemoveItemFromCart(int userId, int itemId);
        bool IsInCart(int userId, int itemId);
    }
}
