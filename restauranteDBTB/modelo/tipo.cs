//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace restauranteDBTB.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo
    {
        public tipo()
        {
            this.produto = new HashSet<produto>();
        }
    
        public int idtipo { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<produto> produto { get; set; }
    }
}
