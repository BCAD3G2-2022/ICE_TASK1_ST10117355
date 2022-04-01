using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI{
    public class SoftdrinkFactory{
        public ISoftdrinks returnInstance;

        public ISoftdrinks GetSoftdrink(string softdrinkType){
            switch(softdrinkType){
                case("fanta"):
                returnInstance = new FantaDrink();
                break;
                case("coke"):
                returnInstance = new CokeDrink();
                break;
            }
            return returnInstance;
        }
    }
}