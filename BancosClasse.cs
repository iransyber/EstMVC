using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudoMVCC.Models
{
    public class BancosClasse
    {
        public int ID { get; set; }

        public String Nome_Banco { get; set; }

        public virtual ICollection<BancosClasse> LBanco { get; set; }
    }
}
