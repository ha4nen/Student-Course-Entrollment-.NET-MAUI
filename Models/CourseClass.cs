using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CourseClass
    {
        [PrimaryKey, AutoIncrement]
        public int Course_Id { get; set; }
        public string Course_Code { get; set; }
        public string Course_Name { get; set; }
    }
}
