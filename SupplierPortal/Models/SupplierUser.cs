using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace SupplierPortal.Models
{
  [ActiveRecord]
  public class SupplierUser : GysmhActiveRecordBase<SupplierUser>
  {
    [PrimaryKey]
    [Display(Name = "主键")]
    public string Id { get; set; }

    [Property("fnumber")]
    [Required]
    [Display(Name = "供应商编码")]
    public String Number {get; set; }

    [Property]	  
    [Display(Name = "供应商名称")]
    public String Name {get; set; }

    [Property] 
    [Required]
    [Display(Name = "密码")]
    public String Password {get; set; }

    [Required]
    [Display(Name = "确认密码")]
    public String ConfirmPassword {get; set; }

    [Property] 
    [Display(Name = "状态")]
    public String Status {get; set; }

    [Property]  
    [Display(Name = "创建时间")]
    public DateTime CreateTime {get; set; }

    [Property] 
    [Display(Name = "更新时间")]
    public DateTime UpdateTime {get; set; }
  }
}