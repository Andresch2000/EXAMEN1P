using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EXAMEN1P.Models
{
    [Table("Contactos")]
    internal class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(100)]
        public string nombres { get; set; }
        [MaxLength(100)]
        public string apellidos { get; set; }
        [NotNull, Unique]
        public string telefonos { get; set; }
        [NotNull]
        public string edades { get; set; }
        [NotNull]
        public string paises { get; set; }
        [MaxLength(200)]
        public string notas { get; set; }


    }
}
