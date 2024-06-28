using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Web.Pages.DataTransfer
{
    public class IndexModel : PageModel
    {
        public int Number { get; set; }
        public List<int> Numbers { get; set; } = default!;


        public void OnGet()
        {
            Numbers = new List<int>() { 1, 2, 3, 4, 5 };
            Number = 10;

            var message = "Merhaba Dünya!";
            ViewData["message"] = message;
            
        }
    }
}
// Razor Page'de data taþýmak için property tanýmlarý yapýldý OnGet() metodunda datalarý verilir.
// IndexModel'i model olarak alan Index.cshtml sayfasýnda datalara eriþim saðlanýr.

// MVC tarafýnda olan kendi oluþturduðumuz model'de data tutan property tanýmlarý,
// controller'da datalarýnýn verilmesi, view sayfasýnda datalara eriþim için hangi modeli alacaðýný belirleme 
// gibi ayrý yerlerde yapýlan iþler Razor'da daha kolaylaþtýrýlýr. 
