using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace razorpages_movie.Pages.Shared.Components
{
    [ViewComponent(Name = "GenreList")]
    public class GenreListModel : ViewComponent
    {

        public List<SelectListItem> Genres { get; set; }

        public List<string> GenreList = new List<string>() { "Action", "Horror", "Drama", "Comedy", "Thriller" };


        public async Task<IViewComponentResult> InvokeAsync()
        {
            Genres = GenreList.Select(genre => new SelectListItem() { Value = genre, Text = genre }).ToList();

            return View(Genres);
        }
    }
}
