
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class AddModel : PageModel
{
    [BindProperty]
    public string NewItem { get; set; }
    public IActionResult OnPost()
    {
        IndexModel.Data.Add(NewItem);
        return RedirectToPage("Index");
    }
}
