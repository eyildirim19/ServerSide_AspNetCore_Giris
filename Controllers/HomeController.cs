using Microsoft.AspNetCore.Mvc;

namespace Giris.Controllers
{
    public class HomeController : Controller
    {

        // IActionResult => bu interface action'ı asp.net core mvc'ye özel responselar oluşturmak için kullanılan tiptir..

        // View() =>  bu metot IActionResult'tan türemiş bir result type'tır. Son kullanıcıya sayfa dönmek için kulanılır...


        //View() metodu eğer aksini belirtmezsek Metot isminde view döner...
        // asp.net mvc'de viewlar .cshtml uzantılıdır. 
        public IActionResult Index()
        {
            return View(); // View
        }
    }
}
