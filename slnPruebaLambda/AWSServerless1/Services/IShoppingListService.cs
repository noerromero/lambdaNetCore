using AWSServerless1.Models;
using System.Collections.Generic;

namespace AWSServerless1.Services
{
    public interface IShoppingListService
    {

        Dictionary<string, int> GetItemFromShoppingList();
        void AddItemShoppingList(ShoppingList shoppingList);

        void RemoveItemShoppingList(string shoppingList);

    }
}
