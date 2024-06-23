using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class StudentClass
    {
        [PrimaryKey,AutoIncrement]
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public string Student_Department { get; set; }
    }
}
