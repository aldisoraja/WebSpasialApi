using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSpasial.EfCore
{
    [Table("tempat")]
    public class Tempat   
    {
        [Key,Required]
        public int id {  get; set; }
        public string nama_pemilik { get; set; } = string.Empty;
        public string nama_tempat { get; set; } = string.Empty;
        public string alamat { get; set; } = string.Empty;
        public string jenis_tempat { get; set; } = string.Empty;
        public string latitude { get; set; } = string.Empty;
        public string longitude { get; set; } = string.Empty;
    }
}
