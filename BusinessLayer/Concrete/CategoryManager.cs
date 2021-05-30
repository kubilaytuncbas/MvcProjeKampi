using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }
        public void CategoryAddBL(Category category)
        {
            if (category.CategoryName=="")
            {
                Console.WriteLine("hatalı giriş");
            }
            else
            {
                categoryDal.Add(category);
            }
        }
    }
}
