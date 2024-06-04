﻿using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<VacationList> VacationList { get; set; }
        public DbSet<AccessLevel> AccessLevel { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<HealthCheckList> HealthChecks { get; set; }
        public DbSet<LoanableItem> LoanableItems { get; set;}
        public DbSet<PositionList> Positions { get; set; }
        public DbSet<SickLeaveList> SickLeaves { get; set;}
    }
}
