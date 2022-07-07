﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using ClothingWebAPI.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace ClothingWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TheLoaiController : ControllerBase
    {
        private readonly ILogger<TheLoaiController> _logger;

        private readonly IConfiguration _configuration;
        public TheLoaiController(IConfiguration configuration, ILogger<TheLoaiController> logger)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<TheLoai> GetAll()
        {
            
            using (var db = new CLOTHING_STOREContext())
            {
                var listTheLoaiBac1 = db.TheLoai.ToList();
                return listTheLoaiBac1;
            }

            return null;
        }
        
    }
}