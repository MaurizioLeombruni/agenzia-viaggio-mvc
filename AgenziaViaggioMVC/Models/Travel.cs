using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenziaViaggioMVC.Models
{
    public class Travel
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string? ImageUrl { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        [Column(TypeName = "smallint")]
        public string? Days { get; set; }

        [Column(TypeName = "smallint")]
        public string? Destinations { get; set; }

        [Column(TypeName = "int")]
        public string? Price { get; set; }
    }
}
