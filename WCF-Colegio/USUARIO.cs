
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
    
public partial class USUARIO
{

    public int IdUsuario { get; set; }

    public string Nombres { get; set; }

    public string Apellidos { get; set; }

    public Nullable<int> IdRol { get; set; }

    public string LoginUsuario { get; set; }

    public string LoginClave { get; set; }

    public string DescripcionReferencia { get; set; }

    public Nullable<int> IdReferencia { get; set; }

    public Nullable<bool> Activo { get; set; }

    public Nullable<System.DateTime> FechaRegistro { get; set; }

    public Nullable<int> RolUsuario { get; set; }



    public virtual ROL ROL { get; set; }

}

}
