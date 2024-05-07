using BuilkyWebReazor_Temp.Data;
using BuilkyWebReazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuilkyWebReazor_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public Category Category { get; set; }

        public void OnGet(int id)
        {
            if (id != 0 && id != null) {
                Category = _db.Categories.Find(id);
            }
        }
        public IActionResult OnPost() {


            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category update successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
