using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JsStore.DataAccess.Data;
using JsStore.DataAccess.Repository.IRepository;
using JsStore.Model;

namespace JsStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Update(Category category)
        {
            var objFromDB = await _dbContext.Categories.FindAsync(category.CategoryID);

            if (objFromDB != null)
            {
                objFromDB.Name = category.Name;
            }
        }
    }
}
