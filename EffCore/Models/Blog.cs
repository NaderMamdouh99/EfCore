using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffCore.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Rate { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Post> Posts { get; set; }
    }
}
