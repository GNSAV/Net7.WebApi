using Net7.WebApi.Entidades.Comun;

namespace Net7.WebApi.Entidades
{
    public class Fruta : BaseEntidad
    {
        public string Nombre { get; set; } = null!;
        public string Color { get; set; } = null!;
        public DateTime? FechaVencimiento { get; set; }
    }
}
