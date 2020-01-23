using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AddingMvcToEmptyProject
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World!";
        }
    }
}
