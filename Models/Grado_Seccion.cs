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
    
    public partial class Grado_Seccion
    {
        public int id { get; set; }
        public Nullable<int> idGrado { get; set; }
        public Nullable<int> idSeccion { get; set; }
    
        public virtual grado grado { get; set; }
        public virtual seccion seccion { get; set; }
    }
}
