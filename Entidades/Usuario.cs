using System.ComponentModel.DataAnnotations;

namespace ForoEFapi.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        //[StringLength(maximumLength: 30)]
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Carrera { get; set; } = null!;
    }
}
