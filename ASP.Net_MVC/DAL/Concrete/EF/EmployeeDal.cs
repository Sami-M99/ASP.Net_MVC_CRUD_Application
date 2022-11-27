using ASP.Net_MVC.Abstract;
using ASP.Net_MVC.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ASP.Net_MVC.Concrete.EF
{
    public class EmployeeDal: BaseRepository<Employee> , IEmployeeDal
    {
    }
}
