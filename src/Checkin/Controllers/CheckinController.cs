using System;
using System.Collections.Generic;
using System.Text;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Checkins.Controllers
{
    public class CheckinController : Barebone.Controllers.ControllerBase
    {
        public CheckinController(IStorage storage) : base(storage)
        {

        }

        public ActionResult Index(int page = 0, int size = 25)
        {
            return View();
        }
    }
}
