using BuilkyWebReazor_Temp.Data;
using BuilkyWebReazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuilkyWebReazor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public void OnGet(int id)
        {
            if (id != 0 && id != null)
            {
                Category = _db.Categories.Find(id);
            }

        }

        public IActionResult OnPost()
        {
            if (Category== null)
            {
                return NotFound();
            } 
            _db.Categories.Remove(Category);
            _db.SaveChanges();
            TempData["success"] = "Category has been deleted successfully";
            return RedirectToPage("Index");
        }
    }
}
