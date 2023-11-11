using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmtityFrameworkApp001
{
    public class Student
    {
        [Key]
        public int No { get; set; }
        public string NAME { get; set; }
        public string MAJOR { get; set; }
        public string HOMETOWN { get; set; }
    }
    //DB 접속모델
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        //접속문자열
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c##scott;Password=c##tiger;Data Source=127.0.0.1/XE;");
        }

        //테이블 생성 및 제약
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()   //Primary key 지정
            .HasKey(p => p.No);

            modelBuilder.Entity<Student>()   //Varchar2(30) 30크기를 정할 때
                .Property(p => p.NAME)
                .HasMaxLength(30);

            modelBuilder.Entity<Student>()
                .Property(p => p.MAJOR)
                .HasMaxLength(30);

            modelBuilder.Entity<Student>()
                .Property(p => p.HOMETOWN)
                .HasMaxLength(30);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // 데이터베이스와 테이블 생성 (필요한 경우)
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // 데이터 삽입
                var students = new List<Student>
                {
                    new Student { No = 100, NAME = "홍길동", MAJOR = "컴공", HOMETOWN = "안동" },
                    new Student { No = 200, NAME = "이순신", MAJOR = "정통", HOMETOWN = "통영" },
                    new Student { No = 300, NAME = "강감찬", MAJOR = "기계", HOMETOWN = "개성" },
                    new Student { No = 400, NAME = "을지문덕", MAJOR = "멀티", HOMETOWN = "서울" }
                };

                context.Students.AddRange(students);
                context.SaveChanges();
                Console.WriteLine("데이터 삽입 완료");

                //UpDate
                var update = context.Students.FirstOrDefault(p => p.No == 100);
                if (update != null)
                {
                    update.NAME = "이성계";
                    update.MAJOR = "화공";
                    update.HOMETOWN = "신의주";

                    context.SaveChanges();
                    Console.WriteLine("데이터 수정 완료");
                }


                //Delete
                var delete = context.Students.FirstOrDefault(p => p.NAME == "을지문덕");
                if (delete != null)
                {
                    context.Students.Remove(delete);

                    context.SaveChanges();
                    Console.WriteLine("데이터 삭제 완료");
                }

            }
        }
    }
}