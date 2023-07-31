﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using razorpages_movie.Data;
using razorpages_movie.Models;
using razorpages_movie.Helpers;

namespace razorpages_movie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly razorpages_movie.Data.razorpages_movieContext _context;

        public List<SelectListItem> Genres { get; set; }



        public CreateModel(razorpages_movie.Data.razorpages_movieContext context)
        {
            _context = context;
        }



        public IActionResult OnGet()
        {
            Genres = Helper.GenreList.Select(genre => new SelectListItem() { Value = genre, Text = genre }).ToList();
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Movie == null || Movie == null)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
