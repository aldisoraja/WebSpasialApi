namespace WebSpasial.Model
{
    public class TempatModel
    {
        public int id { get; set; }
        public string nama_pemilik { get; set; } = string.Empty;
        public string nama_tempat { get; set; } = string.Empty;
        public string alamat { get; set; } = string.Empty;
        public string jenis_tempat { get; set; } = string.Empty;
        public string latitude { get; set; } = string.Empty;
        public string longitude { get; set; } = string.Empty;
    }
}
