﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Georgea_Adina_Lab2.Data;
using Georgea_Adina_Lab2.Models;

namespace Georgea_Adina_Lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Georgea_Adina_Lab2.Data.Georgea_Adina_Lab2Context _context;

        public CreateModel(Georgea_Adina_Lab2.Data.Georgea_Adina_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

       
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
