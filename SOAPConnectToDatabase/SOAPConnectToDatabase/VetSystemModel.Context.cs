﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPConnectToDatabase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VetSystemEntities : DbContext
    {
        public VetSystemEntities()
            : base("name=VetSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public  DbSet<AnimalSubType> AnimalSubTypes { get; set; }
        public  DbSet<AnimalType> AnimalTypes { get; set; }

        public  DbSet<Doctor> Doctors { get; set; }
        public  DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
        public  DbSet<DoctorSpecialtiesDoctor> DoctorSpecialtiesDoctors { get; set; }
        public  DbSet<Owner> Owners { get; set; }
        public  DbSet<Pet> Pets { get; set; }
        public  DbSet<PetStatu> PetStatus { get; set; }
        public  DbSet<Status> Statuses { get; set; }
        public  DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
