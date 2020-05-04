using CetBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.ViewComponents
{
    public class SearchCategoryViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext context;

        public SearchCategoryViewComponent(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cats = await context.Categories.ToListAsync();
            return View(cats);
        }
    }
}
