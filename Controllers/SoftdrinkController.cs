using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers{
    [ApiController]
    [Route("[controller]")]

    public class SoftdrinkController : ControllerBase{
        [HttpGet]
        public List<Softdrinks> Get(String softdrinkType="fanta"){
            SoftdrinkFactory softdrinkFactory = new SoftdrinkFactory();
            ISoftdrinks softdrink = softdrinkFactory.GetSoftdrink(softdrinkType);
            List<Softdrinks> returnedSoftdrink = new List<Softdrinks>();
            returnedSoftdrink.Add(new Softdrinks{flavour = softdrink.getFlavour(),
            diet = softdrink.getDiet()});

            return returnedSoftdrink;
        }
    }
} 