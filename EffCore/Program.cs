using System;

namespace EffCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var employee = new Employee(); 

            _context.Add(employee);
            _context.SaveChanges();
        }
    }
}
