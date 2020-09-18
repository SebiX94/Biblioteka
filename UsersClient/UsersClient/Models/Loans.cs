using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersClient.Models
{
    public class Loans
    {
        public int Id { get; set; }
        public int IdBooks { get; set; }
        public string BookName { get; set; }
        public int IdUsers { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfLoan { get; set; }
        public DateTime DateOfReturn { get; set; }
    }
}
