using System;

namespace SistemaGestionEmpresarial.Modelos
{
    public class UsuarioAutenticado
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public DateTime FechaLogin { get; set; }

        public UsuarioAutenticado()
        {
            FechaLogin = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{NombreUsuario} ({NombreRol})";
        }
    }
}