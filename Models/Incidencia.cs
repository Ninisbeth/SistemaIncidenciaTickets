//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketsIncidencias.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incidencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incidencia()
        {
            this.Historial = new HashSet<Historial>();
        }
    
        public int id_incidencia { get; set; }
        public string referencia { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> ultima_actualizacion { get; set; }
        public Nullable<System.DateTime> fecha_cerrada { get; set; }
        public Nullable<int> creado_por { get; set; }
        public Nullable<int> tipo_incidencia { get; set; }
        public Nullable<int> subtipo_incidencia { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual Estados Estados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historial> Historial { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual SubtipoIncidencia SubtipoIncidencia { get; set; }
        public virtual TipoIncidencia TipoIncidencia { get; set; }
    }
}
