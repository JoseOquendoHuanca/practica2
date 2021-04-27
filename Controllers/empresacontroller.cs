using Microsoft.AspNetCore.Mvc;

namespace practica2.Controllers
{
    public class empresacontroller:Controller
    {
         public IActionResult compra(){
          return   View();
        }
        public IActionResult presentacion(){
          return   View();
        }

        public IActionResult venta (){
          return   View();
        }

    }
}