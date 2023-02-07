using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;




namespace DataAccess.Context
{

    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }

        //names will be used as tables 
        //a list of contact will contain many contacts
        public DbSet<Contact> Contacts { get; set; }
    }
}
