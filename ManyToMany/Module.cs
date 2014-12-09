using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    public class Module
    {
        [Key]
        public int Id { get; set; }

        public String Naam { get; set; }

        public virtual ICollection<Docent> Docenten { get; set; }
    }
}
