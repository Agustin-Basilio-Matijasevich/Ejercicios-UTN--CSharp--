//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba_ASPNET_Clase2LAB4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleados
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> fechanacimiento { get; set; }
        public Nullable<int> id_departamento { get; set; }
    }
}