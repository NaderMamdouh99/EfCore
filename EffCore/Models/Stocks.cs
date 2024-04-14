using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffCore.Models
{
    public class Stocks
    {

        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Symbol { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Sector { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Industry { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Balance { get; set; }
    }
}
