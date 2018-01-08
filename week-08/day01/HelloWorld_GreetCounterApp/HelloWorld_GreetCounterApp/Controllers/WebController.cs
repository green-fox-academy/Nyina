using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

//A Startap namespace-t kell itt megadni .Controllers-szel (mert ez a mappa neve)
namespace HelloWorld_GreetCounterApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static long Counter = 0;

        [Route("greeting")]
        public IActionResult Greeting([FromQuery]string name)
        {
            //object initializer --> rövidítése az értékadásnak (greeting.Id = 1, greeting.Content = "World"-nek
            //Itt nem megy bele a megadott construktorba, hanem a default construktorba 
            //Ugyanazokat a propertyket használja, csak default construktort 
            //(így ha a getterben megadom a name-nél, hogy legyen nagybetűs, akkor a Viweban megcsinálja)
            //megy bele (amiben nincsenek paraméterek, de minden korábban megadott property benne van) - 
            //ez azért jó, mert bármilyen property - érték pár létrehozható,
            //a példány paraméterében vagy construktorában
            //aminek nincs paramétere és nem is kell létrehozni, a Greeting.cshtml-t használja, ami a Hello-t kiírja és a contentet behivatkozza a bodyba
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer

            //var greeting = new Greetings()
            //{
            //    Id = 4,
            //    Content = "World"
            //};

            Counter++;
            var greeting = new Greetings()
            {
                Id = Counter,
                Content = name
            };

            //Az objektumot átadom a View-nak és így eléri és kiírható már bármelyik tulajdonsága (most a Content, 
            //de az Id-t megváltoztattam és azt is behivatkoztam)
            return View(greeting);

        }

    }
}
