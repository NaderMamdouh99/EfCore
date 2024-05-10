using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffCore.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string FirstName { get; set; }
        [Required,MaxLength(50)]
        public string LastName { get; set; }
        public string DisplayName { get; set; }

        public int NationalityId { get; set; }
        [ForeignKey(nameof(NationalityId))]
        public Nationalities Nationalities { get; set; }
        //public int EmployeeId { get; set; }
        //public Employee Employee { get; set; }
    }
}
