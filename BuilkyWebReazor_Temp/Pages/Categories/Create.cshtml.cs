using BuilkyWebReazor_Temp.Data;
using BuilkyWebReazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuilkyWebReazor_Temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        readonly ApplicationDbContext _db;
        //[BindProperty]
        public Category Category{ get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category has been added successfully";
            return RedirectToPage("Index");
        }
    }
}
