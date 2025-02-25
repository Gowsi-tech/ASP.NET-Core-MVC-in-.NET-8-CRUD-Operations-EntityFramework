namespace SuperMarket.Models
{
    public class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category{CategoryId =1, CategoryName="Beverage", CategoryDescription="Beverage"},
            new Category{CategoryId =2, CategoryName="Bakery", CategoryDescription="Bakery"},
            new Category{CategoryId =3, CategoryName="Meat", CategoryDescription="Meat" }
        };

        public static void AddCategory(Category category)
        {
            var maxID = _categories.Max(x => x.CategoryId);
            category.CategoryId = maxID + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                    CategoryDescription = category.CategoryDescription,
                };
            }
            return null;
        }

        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId) return;

            var categoryToUpdate = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
                categoryToUpdate.CategoryDescription = category.CategoryDescription;
            }
        }

        public static void DeleteCategory(int categoryId) {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
        if(category != null)
            {
                _categories.Remove(category);
            }
        }
}
}
