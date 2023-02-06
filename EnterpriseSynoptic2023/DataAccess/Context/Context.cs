using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{

    public class Context : DbContext
    {
        //holds reference to both models

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        //names will be used as tables 
        //a list of contact will contain many contacts
        public DbSet<Contact> Contacts { get; set; }
    }
}
