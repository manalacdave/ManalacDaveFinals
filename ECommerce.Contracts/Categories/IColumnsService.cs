using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.Categories
{
    public interface ICategoriesService : IService
    {
        List<ArticlesDto> GetAll();
    }
}
