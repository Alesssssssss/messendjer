using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using messendjer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace messendjer.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
            public IActionResult Index()
            {
                return View();
            }

        //В этом случае доступ к методу Index имеют только те пользователи, которые залогинились в приложении. Анонимные пользователи же в данном случае при доступе к методу Index будут переадресованы на форму входа в приложение.

        // остальные методы

    }
}
