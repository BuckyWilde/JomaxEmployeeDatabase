using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomaxEmployeeDatabase.Models
{
    public class Certificate
    {
        public int cerificationID { get; set; } = 0;
        public int employeeID { get; set; }
        public string description { get; set; }
        public string comments { get; set; }
        public DateTime dateInitial { get; set; }
        public DateTime? dateExpires { get; set; }
        public bool doesExpire { get; set; }
    }
}
