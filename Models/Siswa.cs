using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models;

    public class SiswaList
    {
        [Key]
        public int id_siswa { get; set; }
        public string id_kelas { get; set; }
        public string id_jurusan { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string nama { get; set; }
        public string nisn { get; set; }

        public long cardNumber { get; set; }

    }
