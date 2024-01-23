using Microsoft.VisualBasic;
using System.Globalization;
using WebSpasial.EfCore;

namespace WebSpasial.Model
{
    public class DbHelper
    {
        private EF_DataContext _Context;
        public DbHelper(EF_DataContext context) {  _Context = context; }

        /// <summary>
        // It serves the GET
        /// </summary>
        public List<TempatModel> GetTempats() 
        { 
            List<TempatModel> response = new List<TempatModel>();
            var dataList = _Context.tempats.ToList();
            dataList.ForEach(row => response.Add(new TempatModel()
            {
                id = row.id,
                nama_pemilik = row.nama_pemilik,
                nama_tempat = row.nama_tempat,
                alamat = row.alamat,
                jenis_tempat = row.jenis_tempat,
                latitude = row.latitude,
                longitude = row.longitude
            }));
            return response;
        }
        /// <summary>
        // It serves the GET (id)
        /// </summary>
        public TempatModel GetTempatsById(int id)
        {
            TempatModel response = new TempatModel();
            var row = _Context.tempats.Where(d=>d.id.Equals(id)).FirstOrDefault();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return new TempatModel()
            {
                id = row.id,
                nama_tempat = row.nama_tempat,
                nama_pemilik = row.nama_pemilik,
                alamat = row.alamat,
                jenis_tempat = row.jenis_tempat,
                latitude = row.latitude,
                longitude = row.longitude
            };
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        /// <summary>
        // It serves the POST/PUT
        /// </summary>  
        public void SaveTempat(TempatModel tempatModel)
        {
            Tempat dbTable = new Tempat();
            if(tempatModel.id > 0)
            {
                dbTable = _Context.tempats.Where(d => d.id.Equals(tempatModel.id)).FirstOrDefault();
                if (dbTable != null)
                {
                    ///PUT
                    dbTable.nama_pemilik = tempatModel.nama_pemilik;
                    dbTable.nama_tempat = tempatModel.nama_tempat;
                    dbTable.alamat = tempatModel.alamat;
                    dbTable.jenis_tempat = tempatModel.jenis_tempat;
                    dbTable.latitude = tempatModel.latitude;
                    dbTable.longitude = tempatModel.longitude;
                }
            }
            else
            {
                ///POST
                dbTable.nama_pemilik = tempatModel.nama_pemilik;
                dbTable.nama_tempat = tempatModel.nama_tempat;
                dbTable.alamat = tempatModel.alamat;
                dbTable.jenis_tempat = tempatModel.jenis_tempat;
                dbTable.latitude = tempatModel.latitude;
                dbTable.longitude = tempatModel.longitude;
                _Context.tempats.Add(dbTable);
            }
            _Context.SaveChanges();
        }

        /// <summary>
        // It serves the DELETE
        /// </summary>
        public void DeleteTempat(int id)
        {
            var tempat = _Context.tempats.Where(d => d.id.Equals(id)).FirstOrDefault();
            if (tempat != null)
            {
                _Context.tempats.Remove(tempat);
                _Context.SaveChanges();
            }
        }
    }
}
