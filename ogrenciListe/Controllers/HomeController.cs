using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ogrenciListe.Models;

namespace ogrenciListe.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var ogrListe = new List<Ogrenci>
            {
                new Ogrenci(){ogrId=1,ogrNo=130, ogrAdSoyad="Ali AS", ogrYas=20},
                new Ogrenci(){ogrId=2,ogrNo=131, ogrAdSoyad="Veli KES", ogrYas=20},
                new Ogrenci(){ogrId=3,ogrNo=132, ogrAdSoyad="Deli KİM", ogrYas=20},
                new Ogrenci(){ogrId=4,ogrNo=133, ogrAdSoyad="Ayşe CİK", ogrYas=20},
                new Ogrenci(){ogrId=5,ogrNo=134, ogrAdSoyad="Zeynep ÖĞREN", ogrYas=20},
                new Ogrenci(){ogrId=6,ogrNo=135, ogrAdSoyad="Leyla DATE", ogrYas=20}

            };
            return View( ogrListe );
        }
    }
}