using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class EntrollClass
    {
        [PrimaryKey, AutoIncrement]
        public int Entroll_Id { get; set; }
        public int Student_Id { get; set; }
        public string Course_Code { get; set; }
    }
}
