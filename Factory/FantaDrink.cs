using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class FantaDrink: ISoftdrinks{
    public string getFlavour(){
        return "fanta";
    }
    public string getDiet(){
        return "no diet";
    }
}