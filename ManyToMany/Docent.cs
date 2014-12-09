using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ManyToMany
{
    public class Docent
    {
        [Key]
        public int  Id { get; set; }

        public String Naam { get; set; }

        public virtual ICollection<Module> Modules { get; set; }


    }
}
