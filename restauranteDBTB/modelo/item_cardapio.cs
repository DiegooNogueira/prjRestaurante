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
    
    public partial class item_cardapio
    {
        public int item_cardapio1 { get; set; }
        public int idcardapio { get; set; }
        public int idproduto { get; set; }
    
        public virtual cardapio cardapio { get; set; }
        public virtual produto produto { get; set; }
    }
}
