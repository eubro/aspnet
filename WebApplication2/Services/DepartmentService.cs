﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class DepartmentService
    {
        private readonly WebApplication2Context _context;

        public DepartmentService(WebApplication2Context context)
        {
            _context = context;
        }
        public async Task< List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();

        }
    }
}
