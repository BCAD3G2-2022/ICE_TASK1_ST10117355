using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class CokeDrink: ISoftdrinks{
    public string getFlavour(){
        return "coke";
    }
    public string getDiet(){
        return "diet";
    }
}