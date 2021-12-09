using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models;

    public class KelasList
    {
        [Key]
        public int id_kelas { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string nama_kelas { get; set; }

        public long cardNumber { get; set; }

    }
