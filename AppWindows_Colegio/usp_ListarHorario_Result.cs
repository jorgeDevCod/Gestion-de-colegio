//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppWindows_Colegio
{
    using System;
    
    public partial class usp_ListarHorario_Result
    {
        public int IdHorario { get; set; }
        public Nullable<int> IdCurso { get; set; }
        public Nullable<int> IdNivel { get; set; }
        public Nullable<int> IdGradoSeccion { get; set; }
        public string DiaSemana { get; set; }
        public string NombreCurso { get; set; }
        public Nullable<System.TimeSpan> HoraInicio { get; set; }
        public Nullable<System.TimeSpan> HoraFin { get; set; }
        public Nullable<bool> Activo { get; set; }
    }
}
