﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoPractical
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class trainingEntities : DbContext
    {
        public trainingEntities()
            : base("name=trainingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmploeeTable> EmploeeTables { get; set; }
        public virtual DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Mobile_Details> Mobile_Details { get; set; }
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<ClientTableData> ClientTableDatas { get; set; }
        public virtual DbSet<ClientTaEmployeeDepartmentTableDetailsbleData> ClientTaEmployeeDepartmentTableDetailsbleDatas { get; set; }
        public virtual DbSet<CustomerEntryTable> CustomerEntryTables { get; set; }
        public virtual DbSet<EmployeeTableDetail> EmployeeTableDetails { get; set; }
        public virtual DbSet<MobileDetail> MobileDetails { get; set; }
        public virtual DbSet<StudentRegisteration> StudentRegisterations { get; set; }
        public virtual DbSet<UserTableDetail> UserTableDetails { get; set; }
    }
}
