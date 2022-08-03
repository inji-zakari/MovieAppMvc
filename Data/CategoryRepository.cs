using MovieAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppMvc.Data
{
    public class CategoryRepository
    {
         private static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
               new Category(){Id=1,Name="Adventure"},
               new Category(){Id=2,Name="Fantastic"},
               new Category(){Id=3,Name="Motivation"},
               new Category(){Id=4,Name="Scientific"},
               new Category(){Id=5,Name="War"}
            };
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }

    }
}