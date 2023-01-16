using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenziaViaggioMVC.Models
{
    public class Travel
    {
        public int Id { get; set; }


        [Column(TypeName = "varchar(500)")]
        [StringLength(500, ErrorMessage = "Input [ImageUrl] is too many characters (max. 500)")]
        public string? ImageUrl { get; set; }

        [Column(TypeName = "varchar(50)")]
        [StringLength(500, ErrorMessage = "Input [Name] is too many characters (max. 50)")]
        public string? Name { get; set; }

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        [Column(TypeName = "tinyint")]
        [Range(0, 255, ErrorMessage = "Input value for [Days] is not valid. (0-255)")]
        public int? Days { get; set; }

        [Column(TypeName = "tinyint")]
        [Range(0, 255, ErrorMessage = "Input value for [Destinations] is not valid. (0-255)")]
        public int? Destinations { get; set; }

        [Column(TypeName = "smallint")]
        [Range(0, 255, ErrorMessage = "Input value for [Price] is not valid. (0-32768)")]
        public int? Price { get; set; }

        public Travel() { }

        public Travel(int id, string? imageUrl, string? name, string? description, int? days, int? destinations, int? price)
        {
            Id = id;
            ImageUrl = imageUrl;
            Name = name;
            Description = description;
            Days = days;
            Destinations = destinations;
            Price = price;
        }
    }
}
