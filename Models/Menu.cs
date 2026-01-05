namespace DotNetMenu.Models
{

    //Menu data is hardcoded in this class
    public class Menu
    {
        public IReadOnlyList<MenuItem> Items { get; }

        public Menu()
        {
            Items = new List<MenuItem>
            {
                new MenuItem("Spaghetti Bolognese", 12m),
                new MenuItem("Margherita Pizza", 10m),
                new MenuItem("Caesar Salad", 8m),
                new MenuItem("Grilled Salmon", 15m),
                new MenuItem("Tiramisu", 6m)
            };
        }

    }
}
