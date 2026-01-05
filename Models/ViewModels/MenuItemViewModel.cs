namespace DotNetMenu.Models.ViewModels
{

    //MenuItem represents a "real" data, where MenuViewModel is a "view" data
    //ViewDAta can bew modified for display purposes without affecting the real data
    public class MenuItemViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItemViewModel(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
