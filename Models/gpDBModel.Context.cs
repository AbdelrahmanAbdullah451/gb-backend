﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gb_raw.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gbDataBaseEntities : DbContext
    {
        public gbDataBaseEntities()
            : base("name=gbDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<EssayAnswer> EssayAnswers { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<MCQAnswer> MCQAnswers { get; set; }
        public virtual DbSet<MCQQuestion> MCQQuestions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<SysUser> SysUsers { get; set; }
        public virtual DbSet<TFAnswer> TFAnswers { get; set; }
        public virtual DbSet<StudentsAllowed> StudentsAlloweds { get; set; }
    }
}
