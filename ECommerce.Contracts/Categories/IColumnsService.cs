using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.Columns
{
    public interface IColumnsService : IService
    {
        List<ColumnsDto> GetAll();
    }
}
