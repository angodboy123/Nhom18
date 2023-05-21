using System.ComponentModel.DataAnnotations;
namespace Nhom18.Models;
public class Sanpham {
    [Key]
    [Display( Name = "Mã Sản Phẩm")]
    public string? MaSP { get; set;}
    [Display(Name = "Sản phẩm")]
    public string? TenSP { get; set;}
    [Display(Name = "Giá")]
    public string? GiaSP { get; set; }

}