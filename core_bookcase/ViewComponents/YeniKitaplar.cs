using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_bookcase.Models;

namespace core_bookcase.ViewComponents
{
    public class YeniKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitapListesi = new List<Kitaplar>
            {
                new Kitaplar
                {
                    ID=6,
                    KitapAd="Korku",
                    Yazar="Zweig"
                 },

                new Kitaplar
                 {
                    ID=7,
                    KitapAd="Anna Karanina",
                    Yazar="Tolstoy"

                }
            };
            return View(kitapListesi);
        }

    }

}

