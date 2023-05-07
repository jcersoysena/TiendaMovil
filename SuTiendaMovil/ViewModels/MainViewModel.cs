

namespace SuTiendaMovil.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private IEnumerable<Category> _categories;

        public MainViewModel()
        {
            Categories = LoadCategories();
        }
        private static IEnumerable<Category> LoadCategories()
        {
            return new List<Category>
            {
                new Category (1,"Hamburgesas","burgers.png"),
                new Category (2,"Helados","desserts.png"),
                new Category (3,"Carnes","nonveg.png"),
                new Category (4,"Pizza","pizza.png"),
                new Category (5,"Granos","rice.jpg"),
                new Category (6,"Pescados","seafood.jpg"),
                new Category (7,"Sopas","soups.png"),
                new Category (8,"Vegetales","veg.png"),

            };
        }
    }
}
