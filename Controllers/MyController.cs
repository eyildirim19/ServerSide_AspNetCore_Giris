using Microsoft.AspNetCore.Mvc;

namespace Giris.Controllers
{
    // Controllerlar url'den sadece Name ile çağrılır..
    // örnek: localhost:portNo/My
    // Requestler controllerlara yapılır. Aslında reqeust controller içerisinde metoda yapılır. bu metotlara action denir.. actionlar controllerları oluşturan unsurlardır...
    public class MyController : Controller
    {
        public string Index()
        {
            return "Ben bu controllerin default action'ıyım...";
        }

        public string Mesaj()
        {
            return "Merhaba MVC";
        }

        public int Islem()
        {
            return 2 + 4;
        }
    }
}