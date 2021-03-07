using JsStore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JsStore.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task Update(Category category);
    }
}
