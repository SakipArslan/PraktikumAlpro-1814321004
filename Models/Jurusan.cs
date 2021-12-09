using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models;

    public class JurusanList
    {
        [Key]
        public int id_jurusan { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string nama_jurusan { get; set; }
        public string singkatan { get; set; }

        public long cardNumber { get; set; }

    }
