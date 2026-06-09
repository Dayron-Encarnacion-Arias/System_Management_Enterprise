namespace SistemaGestionEmpresarial
{
    public static class SesionGlobal
    {
        public static UsuarioAutenticado UsuarioActual { get; set; }

        public static bool HayUsuarioAutenticado()
        {
            return UsuarioActual != null;
        }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}