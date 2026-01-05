namespace DotNetMenu.Models.ViewModels
{

    //View Model, that represents meny based on conditions (logic will be in controller)
    public class MenuViewModel
    {
        public IReadOnlyList<MenuItemViewModel> ItemViewModels { get; }

        public MenuViewModel(IReadOnlyList<MenuItemViewModel> itemViewModels)
        {
            ItemViewModels = itemViewModels;
        }
     }
}
