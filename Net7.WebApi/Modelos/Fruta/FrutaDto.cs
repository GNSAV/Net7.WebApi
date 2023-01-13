namespace Net7.WebApi.Modelos
{
    public class FrutaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }

        public FrutaDto(Entidades.Fruta fruta)
        {
            Id = fruta.Id;
            Nombre = fruta.Nombre;
            Color = fruta.Color;
        }
    }

}
