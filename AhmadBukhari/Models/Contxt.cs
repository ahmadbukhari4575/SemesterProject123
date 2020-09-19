using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AhmadBukhari.Models
{
    public class Contxt : DbContext
    {
        public Contxt() : base("name=Contxt")
        {
        }

        public DbSet<Hostel> Hostels { get; set; }

    }
}