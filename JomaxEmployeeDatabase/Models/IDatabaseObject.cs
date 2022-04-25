using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomaxEmployeeDatabase.Models
{
    public interface IDatabaseObject
    {
        public int Id { get; set; }
        public string tableName { get; }
    }
}
