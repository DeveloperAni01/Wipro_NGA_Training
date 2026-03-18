
using Microsoft.AspNetCore.Mvc.RazorPages;
public class IndexModel : PageModel
{
    public static List<string> Data = new();
    public List<string> Items => Data;
    public void OnGet() { }
}
