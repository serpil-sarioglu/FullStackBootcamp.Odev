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

            var message = "Merhaba D�nya!";
            ViewData["message"] = message;
            
        }
    }
}
// Razor Page'de data ta��mak i�in property tan�mlar� yap�ld� OnGet() metodunda datalar� verilir.
// IndexModel'i model olarak alan Index.cshtml sayfas�nda datalara eri�im sa�lan�r.

// MVC taraf�nda olan kendi olu�turdu�umuz model'de data tutan property tan�mlar�,
// controller'da datalar�n�n verilmesi, view sayfas�nda datalara eri�im i�in hangi modeli alaca��n� belirleme 
// gibi ayr� yerlerde yap�lan i�ler Razor'da daha kolayla�t�r�l�r. 
