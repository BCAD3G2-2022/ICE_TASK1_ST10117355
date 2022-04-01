using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI{
    public class BurgerFactory {
        public IBurger returnInstance;

        public IBurger getBurger(String burgerType){
            switch(burgerType){
                case("chicken"):
                returnInstance = new ChickenBurger();
                break;
                case("plain"):
                returnInstance = new PlainBurger();
                break;
                case("cheese"):
                returnInstance = new CheeseBurger();
                break;
                case("veggie"):
                returnInstance = new VeggieBurger();
                break;
            }
            return returnInstance;
        }
    }
}
