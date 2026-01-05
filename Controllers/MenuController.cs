using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetMenu.Models;
using DotNetMenu.Models.ViewModels;

namespace DotNetMenu.Controllers;


    public class MenuController : Controller
    {

    //This method passes a Menu model to the MenuView.cshtml view
    //You can only pass one item. You iterate through the model in the view.
    //Method name should match the view name.
    
    [HttpGet]
        public IActionResult MenuView(int age)
        {
            var menu = new Menu();
        decimal discountModyfier = 1.0m;

        if (age is < 18 or >= 65) {
            discountModyfier = 0.9m;

        }

        var menuItemViewModels = menu.Items.Select(item =>
            new MenuItemViewModel(item.Name, item.Price * discountModyfier)).ToList();

        var menuWievModel = new MenuViewModel(menuItemViewModels);






            return View(menuWievModel);
    }
}

