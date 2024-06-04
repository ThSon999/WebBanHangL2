using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Chưa nhập dữ liệu"),StringLength(50)]
        public String Name { get; set; }
        [Range(1,100,ErrorMessage = "Dữ liệu chỉ từ 1 đến 100")]
        public int DisplayOrder { get; set; }
    }
}
