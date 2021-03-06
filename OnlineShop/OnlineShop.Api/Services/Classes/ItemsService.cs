﻿using System.Collections.Generic;
using OnlineShop.Bll.Repositories.Interfaces;
using OnlineShop.Api.Services.Interfaces;
using OnlineShop.Common.DbModels;

namespace OnlineShop.Api.Services.Classes
{
    public class ItemsService : IItemsService
    {
        private readonly IItemsManagementBLL _itemsManagementBLL;
        public ItemsService(IItemsManagementBLL itemsManagementBLL)
        {
            _itemsManagementBLL = itemsManagementBLL;
        }
        public Items AddItem(int? prodId, int? color, int? size, int? quantity, string image)
        {
            var item = new Items { ProductId = prodId, Color = color, Size = size, Quantity = quantity, Image = image };

            _itemsManagementBLL.AddItem(item);

            return item;
        }

        public void DeleteItem(int id)
        {
            _itemsManagementBLL.RemoveItemById(id);
        }

        public Items UpdateItem(Items oldItem, Items newItem)
        {
            return _itemsManagementBLL.UpdateItem(oldItem, newItem);
        }

        public IEnumerable<Items> GetAllItemsByPage(int count, int page)
        {
            return _itemsManagementBLL.GetAllItemsByPage(count, page);
        }

        public IEnumerable<Items> GetAllItemsOfProductByPage(int count, int page, int productId)
        {
            return _itemsManagementBLL.GetAllItemsOfProductByPage(count, page, productId);
        }
        public bool SearchById(int id)
        {
            return _itemsManagementBLL.SearchById(id);
        }

        public Items GetById(int id)
        {
            return _itemsManagementBLL.GetItemById(id);
        }
    }
}
