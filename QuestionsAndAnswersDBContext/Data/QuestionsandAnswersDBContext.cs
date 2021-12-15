using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswersDBContext.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersDBContext.Data
{
    public partial class QuestionsandAnswersDBContext : DbContext
    {
        public QuestionsandAnswersDBContext()
        {
        }

        public QuestionsandAnswersDBContext(DbContextOptions<QuestionsandAnswersDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Registration> UserRegistrations { get; set; }
        public virtual DbSet<QuestionsAndAnswers> QuestionandAnswers { get; set; }

        public virtual DbSet<Technology> MasterTechnologies { get; set; }

        public virtual DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey("UserId");
                
                entity.ToTable("UserRegistration");

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.RoleId).HasColumnName("RoleId");

                entity.Property(e => e.Username).HasMaxLength(150);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(100)
                    /*.IsUnicode(false)*/;

                entity.Property(e => e.ConfirmPassword).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(maxLength:100)
                    /*.IsUnicode(false)*/;

                entity.Property(e => e.YearsOfExperience).HasColumnName("YearsOfExperience");

                entity.Property(e => e.Technology).HasMaxLength(100);                
            });

            modelBuilder.Entity<Technology>(entity =>
            {
                entity.ToTable("MasterTechnology");
                
                entity.HasKey("TechnologyId");
                entity.Property(e => e.TechnologyId);

                entity.Property(e => e.TechnologyName);                                    
            });

            modelBuilder.Entity<QuestionsAndAnswers>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("QuestionandAnswer");
                entity.HasKey("QuestionID");

                entity.Property(e => e.QuestionID).HasColumnName("QuestionID").ValueGeneratedOnAdd();
                entity.Property(e => e.TechnologyId).HasColumnName("TechnologyId");

                entity.Property(e => e.Question);

                entity.Property(e => e.Option1);
                entity.Property(e => e.Option2);
                entity.Property(e => e.Option3);
                entity.Property(e => e.Option4);
                entity.Property(e => e.ActualAnswer);                
            });

            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasKey("AnswersId");

                entity.ToTable("Answers");
                entity.Property(e => e.AnswersId).ValueGeneratedOnAdd();

                entity.Property(e => e.ReceivedAnswers)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasColumnType("Result");
                
                entity.Property(e => e.UserId).HasColumnName("UserId");
                entity.Property(e => e.TechnologyId).HasColumnName("TechnologyId");
                entity.Property(e => e.QuestionId).HasColumnName("QuestionId");                                
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey("RoleId");                                    
                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false);                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
