//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plataforma_Estudiantil.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notas_Periodos
    {
        public int id { get; set; }
        public Nullable<int> idNotas { get; set; }
        public Nullable<int> idPeriodos { get; set; }
    
        public virtual Nota Nota { get; set; }
        public virtual Periodo Periodo { get; set; }
    }
}
