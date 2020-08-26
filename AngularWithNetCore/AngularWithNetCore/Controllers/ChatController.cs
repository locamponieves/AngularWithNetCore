﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularWithNetCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AngularWithNetCore.Controllers
{
    [Route("api/[controller]")]
    public class ChatController : Controller
    {
        private Models.MyDBContext db;

        public ChatController(Models.MyDBContext context)
        {
            db = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<MessageViewModel> Message()
        {
            List<MessageViewModel> lst = (from d in db.Message
                                          select new MessageViewModel
                                          {
                                              Id = d.Id,
                                              Name = d.Name,
                                              Text = d.Text
                                          }).ToList();
            return lst;
        }
    }
}
