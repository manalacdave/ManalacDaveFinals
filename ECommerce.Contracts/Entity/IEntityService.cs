﻿using ECommerce.Contracts.Common;
using ECommerce.Contracts.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.Entity
{
    public interface IEntityService : IArticleService
    {
        Paged<EntityDto> Search(int? pageIndex = 1,
                             int? pageSize = 10,
                             string? sortBy = "",
                             string? keyword = "");

        Guid? Create(EntityDto? dto);
        Guid? Update(EntityDto? dto);
        Guid? Delete(Guid? entityId);
        EntityDto? GetById(Guid? entityId);
    }
    public class ViewModel
    {
        public string? Login { get; set; }
        public int? IArticlesService { get; set; }
    }
}
