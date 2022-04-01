using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomBurgerController : ControllerBase
    {
        [HttpGet]
        public List<string> Get(bool tomato, bool cheese, bool lettuce, bool bun, bool patty){
            IComponent burgerBun = new Bun();
            IComponent burgerPatty = new Patty();
            IComponent burgerLettuce = new Lettuce();
            IComponent burgerTomato = new Tomato();
            IComponent burgerCheese = new Cheese();

            Composite BaseBurger= new Composite();
            BaseBurger.addPart(burgerBun);
            BaseBurger.addPart(burgerLettuce);
            BaseBurger.addPart(burgerTomato);
            BaseBurger.addPart(burgerCheese);
            BaseBurger.addPart(burgerPatty);

            if(tomato){
                BaseBurger.removePart(burgerTomato);
            }
            if(lettuce){
                BaseBurger.removePart(burgerLettuce);
            }
            
            List<string> returnList = new List<string>();
            returnList.Add(BaseBurger.getPart());
            return returnList;
                       
        }
    }
}
