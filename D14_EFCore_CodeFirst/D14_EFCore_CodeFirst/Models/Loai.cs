using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace D14_EFCore_CodeFirst.Models
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        [MaxLength(50)]
        [Required]
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        [MaxLength(50)]
        public string Hinh { get; set; }
    }
}
