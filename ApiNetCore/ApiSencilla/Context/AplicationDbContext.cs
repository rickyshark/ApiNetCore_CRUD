﻿using ApiSencilla.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSencilla.Context
{
    public class AplicationDbContext:DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }


        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
