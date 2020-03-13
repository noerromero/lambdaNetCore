using AWSServerless1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSServerless1.Services
{
    public class ShoppingListService : IShoppingListService
    {

        private Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();
        public Dictionary<string, int> GetItemFromShoppingList()
        {
            return _shoppingListStorage;
        }


        public void AddItemShoppingList(ShoppingList shoppingList) {
            _shoppingListStorage.Add(shoppingList.Name, shoppingList.Quantity);
        }

    }
}
    