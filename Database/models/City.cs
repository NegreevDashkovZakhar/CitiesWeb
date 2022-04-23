using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CitiesWeb.Database.models
{
    public class City
    {
        [Key]
        [ForeignKey("coords")]
        public int cityId { get; set; }
        public Coordinates coords { get; set; }
        public string district { get; set; }
        public string name { get; set; }
        public long population { get; set; }
        public string subject { get; set; }
    }
}
