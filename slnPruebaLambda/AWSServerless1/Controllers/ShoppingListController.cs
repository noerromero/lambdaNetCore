using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSServerless1.Models;
using AWSServerless1.Services;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerless1.Controllers
{
    [Route("v1/shoppingList")]
    public class ShoppingListController : Controller
    {

        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService) {
            _shoppingListService = shoppingListService;
        }


        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemFromShoppingList();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemShoppingList([FromBody] ShoppingList shoppingList) {
            _shoppingListService.AddItemShoppingList(shoppingList);

            return Ok();
        }

        public IActionResult RemoveItemShoppingList([FromBody] ShoppingList shoppingList)
        {
            _shoppingListService.RemoveItemShoppingList(shoppingList.Name);
            return Ok();
        }
    }
}