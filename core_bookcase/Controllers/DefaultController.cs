using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_bookcase.Models;


namespace core_bookcase.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {

            var ktp = new List<Kitaplar>()
            {

             new Kitaplar() { ID = 1, KitapAd = "Satranç", Yazar = "Zweig"},
            new Kitaplar() { ID = 2, KitapAd = "Kürk Mantolu Madonna", Yazar = "Sabahattin Ali"},
            new Kitaplar() { ID = 3, KitapAd = "Küçük Prens", Yazar = "Antoine de Saint-Exupéry"},
            new Kitaplar() { ID = 4, KitapAd = "Şeker Portakalı", Yazar = "José Mauro de Vasconcelos" },
            new Kitaplar() { ID = 5, KitapAd = "Hayvan Çiftliği", Yazar = "George Orwell"},
        };
            return View(ktp);

        }
    }
}
