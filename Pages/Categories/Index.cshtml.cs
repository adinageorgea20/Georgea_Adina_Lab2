using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Georgea_Adina_Lab2.Data;
using Georgea_Adina_Lab2.Models;
using Georgea_Adina_Lab2.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Georgea_Adina_Lab2.Pages.Categories
{
    [Authorize(Roles = "Admin")]

    public class IndexModel : PageModel
    {
        private readonly Georgea_Adina_Lab2.Data.Georgea_Adina_Lab2Context _context;

        public IndexModel(Georgea_Adina_Lab2.Data.Georgea_Adina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;
        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }

        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();

            Category = await _context.Category
                 .Include(c => c.BookCategories)
                 .ThenInclude(bc => bc.Book)
                 .ThenInclude(b => b.Author)
                 .OrderBy(c => c.CategoryName)
                 .ToListAsync();

            CategoryData.Categories = Category;

            if (id != null)
            {
                CategoryID = id.Value;
                Category category = Category
                    .Where(c => c.ID == id.Value).Single();

                if (category != null)
                {
                    CategoryData.Books = category.BookCategories.Select(bc => bc.Book).ToList();
                }
            }
        }
    }
}
