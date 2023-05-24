using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Nhom18.Models;
public class Nhaphang {
    [Key]
    public string? IDNH { get; set;}
    
    public string? TenSP { get; set;}
    [ForeignKey("TenSP")]
      [Display( Name = "Tên Sản phẩm")]
    
    public Sanpham? Sanpham { get; set;}
    
    [Display( Name = "Số lượng")]
    public string? SoluongSP {get; set;}
   
    public string? TenNCC { get; set;}
    [ForeignKey("TenNCC")]
    [Display( Name = "Nhà Cung Cấp")]
    
    public Nhacungcap? Nhacungcap { get; set;}
    
    
    public string? TenNV { get; set;}
    [ForeignKey("TenNV")][Display( Name = "Nhân Viên")]

    
    public Nhanvien? Nhanvien { get; set;}
    
    [DataType(DataType.Date)]
    [Display( Name = "Ngày Nhập Hàng")]
    
    public DateTime NgaynhapSP {get; set;}
    
}