using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november4_task.Exceptions
{
    internal class EmployeeNotFound : Exception
    {
        public EmployeeNotFound(string? message) : base(message)
        {
        }
    }
}
