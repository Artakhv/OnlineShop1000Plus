﻿using System;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Bll.Repositories.Interfaces;
using OnlineShop.Common;

namespace OnlineShop.Api.Controllers
{
    public class TestController : CustomBaseController
    {
        private readonly IUserManagementBLL _userManagementBLL;
        public TestController(IUserManagementBLL userManagementBLL)
        {
            _userManagementBLL = userManagementBLL;
        }
        
        [HttpGet]
        public IActionResult Test()
        {
            OnlineShopAlphaContext context = new OnlineShopAlphaContext();
            return Ok($"Test {DateTime.UtcNow}");
        }

        [HttpGet]
        public IActionResult UserByEmail([FromBody]string email)
        {
            _userManagementBLL.GetUserByEmail(email);
            return Ok();

        }
    }
}