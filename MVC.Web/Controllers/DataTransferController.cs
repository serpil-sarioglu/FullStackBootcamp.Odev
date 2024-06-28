using Microsoft.AspNetCore.Mvc;
using MVC.Web.Models;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace MVC.Web.Controllers
{
    public class DataTransferController : Controller
    {
        public IActionResult Index()
        {
            
            //ViewData, Controller'dan View'a veri aktarmak için kullanılan bir yöntemdir.
            //ViewData, anahtar - değer çiftleri koleksiyonu olan bir sözlük(dictionary) gibi çalışır ve veriyi geçici olarak saklar.
            //Tip güvenliği yok.

            var  name = "Can";
            ViewData["name"] = name;

            var names= new List<string>() { "Ali","Mehmet","Ayşe","Gülay"};
            ViewData["nameList"] = names;


            //ViewBag, Controller'dan View'a veri aktarmak için kullanılan bir başka yöntemdir.
            //ViewData'nın daha kolay ve okunabilir bir versiyonudur.
            //ViewBag, `dynamic` anahtar sözcüğü ile tanımlandığı için, dinamik olarak anahtar-değer çiftleri şeklinde veri tutabilir.
            //Tip güvenliği yok.

            var number = 10;
            ViewBag.number = number;            

            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            ViewBag.numberList = numbers;


            //ViewModel, Controller'dan View'a veri aktarmak için kullanılan bir başka yöntemdir.
            //ViewModel, View'a özgü verileri toplar ve Controller'ın karmaşıklığını azaltır.
            //ViewModel kullanarak tip güvenli ve daha okunabilir bir yapı sağlar.
            //Verilerde boxing-unboxing işlemi gerçekleştirilmez.    

            var pageModel = new IndexPageViewModel
            {
                Name = name,
                Names = names,
                Number = number,
                Numbers = numbers
            };

            return View(pageModel);
        }

        //TempData, bir sayfadan başka bir sayfaya data taşınmak isteniyorsa kullanılır.(OnePage'ten TwoPage sayfasına data taşınacak burada)
        //TempData gizli olarak datayı cookielerde taşır.
        //TempData'da tutulan data diğer sayfa okunduğu anda otomatik bir şekilde cookieden silinir.

        public IActionResult OnePage() 
        {
            TempData["userId"] = 10;
            return View();
        }
        public IActionResult TwoPage()
        {
            return View();
        }
    }
}
