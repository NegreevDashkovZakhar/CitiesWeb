using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CitiesWeb.Database.models
{
    public class Coordinates
    {
        [Key]
        public int coordinatesId { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
    }
}
