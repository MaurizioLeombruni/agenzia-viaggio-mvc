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
        [Range(1, 255, ErrorMessage = "Input value for [Days] is not valid. (1-255)")]
        public int? Days { get; set; }

        [Column(TypeName = "tinyint")]
        [Range(1, 255, ErrorMessage = "Input value for [Destinations] is not valid. (1-255)")]
        public int? Destinations { get; set; }

        [Column(TypeName = "smallint")]
        [Range(1, 255, ErrorMessage = "Input value for [Price] is not valid. (1-32768)")]
        public int? Price { get; set; }

        [Column(TypeName = "varchar(20)")]
        [StringLength(20, ErrorMessage = "Input for Color not valid.")]
        public string? Color { get; set; }

        public Travel() { }

        public Travel(int id, string? imageUrl, string? name, string? description, int? days, int? destinations, int? price, string? color)
        {
            Id = id;
            ImageUrl = imageUrl;
            Name = name;
            Description = description;
            Days = days;
            Destinations = destinations;
            Price = price;
            Color = color;
        }
    }
}
