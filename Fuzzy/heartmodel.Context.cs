﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fuzzy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class heartbaseEntities : DbContext
    {
        public heartbaseEntities()
            : base("name=heartbaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Memberships> Memberships { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<Results> Results { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Users_results> Users_results { get; set; }
        public DbSet<Userss> Userss { get; set; }
    }
}
