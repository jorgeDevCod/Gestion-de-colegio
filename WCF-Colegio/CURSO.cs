
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WCF_Colegio
{

using System;
    using System.Collections.Generic;
    
public partial class CURSO
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public CURSO()
    {

        this.ALUMNO = new HashSet<ALUMNO>();

        this.DOCENTE = new HashSet<DOCENTE>();

        this.Notas = new HashSet<Notas>();

    }


    public int IdCurso { get; set; }

    public string Descripcion { get; set; }

    public Nullable<bool> Activo { get; set; }

    public Nullable<System.DateTime> FechaRegistro { get; set; }

    public string CODIGO { get; set; }

    public Nullable<int> IDNivel { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ALUMNO> ALUMNO { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DOCENTE> DOCENTE { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Notas> Notas { get; set; }

    public virtual NIVEL NIVEL { get; set; }

}

}
