﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectronicMagazine.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ElectronicMagazineEntities : DbContext
    {
        public static ElectronicMagazineEntities _context;
        public ElectronicMagazineEntities()
            : base("name=ElectronicMagazineEntities")
        {
        }
        public static ElectronicMagazineEntities GetContext()
        {
            if (_context == null)
                _context = new ElectronicMagazineEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AttendanceID> AttendanceID { get; set; }
        public virtual DbSet<GradesID> GradesID { get; set; }
        public virtual DbSet<GroupID> GroupID { get; set; }
        public virtual DbSet<SalaryID> SalaryID { get; set; }
        public virtual DbSet<ScheduleID> ScheduleID { get; set; }
        public virtual DbSet<StudentID> StudentID { get; set; }
        public virtual DbSet<SubjectID> SubjectID { get; set; }
        public virtual DbSet<TeacherID> TeacherID { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Document> Document { get; set; }
    }
}
