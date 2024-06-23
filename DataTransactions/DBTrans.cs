using Project.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }
        public void InitS()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<StudentClass>();
        }
        public void InitC()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<CourseClass>();
        }
        public void InitE()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<EntrollClass>();
        }

        public List<StudentClass> GetAllStudents()
        {
            InitS();
            return conn.Table<StudentClass>().ToList();
        }
        public List<CourseClass> GetAllCourses()
        {
            InitC();
            return conn.Table<CourseClass>().ToList();
        }
        public List<EntrollClass> GetAllEntroll()
        {
            InitE();
            return conn.Table<EntrollClass>().ToList();
        }

        public void AddS(StudentClass student)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }
        public void AddC(CourseClass course)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(course);
        }
        public void AddE(EntrollClass entroll)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(entroll);
        }

        public void DeleteS(int student_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new StudentClass { Student_Id = student_id });
        }
        public void DeleteC(int course_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new CourseClass { Course_Id = course_id });
        }
        public void DeleteE(int entroll_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new EntrollClass { Entroll_Id = entroll_id });
        }
    }
}