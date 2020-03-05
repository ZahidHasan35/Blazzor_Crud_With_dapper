using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCrud.Data
{
    public class EmployeeModel : Employee
    {
        public string CityName { get; set; }
    }
}
