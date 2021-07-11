using issue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace issue.Controllers
{
    public class UserDto
    {
        public List<string> Location { get; set; } = new();
    }

    public class HomeController : Controller
    {
        public async Task<IActionResult> Index(UserDto model)
        {
            var userDto = new UserDto();
            await TryUpdateModelAsync(userDto);
            return View(userDto);
        }


    }
}
