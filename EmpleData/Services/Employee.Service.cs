using EmpleData.Models;
using EmployeeData.Models; 
using System.Collections.Generic; 
using System.Linq; 

namespace EmployeeData.Services 
{
    public class EmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployee() 
        {
            return _context.employee.ToList(); 
        }

        public void Add(Employee entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "El empleado no puede ser nulo."); 
            }

            _context.employee.Add(entity);
            _context.SaveChanges(); 
        }
    }
}
