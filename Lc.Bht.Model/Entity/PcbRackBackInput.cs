//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
//     author CHENGE
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace Lc.Bht.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("pcb_rack_back_input")]
    public class PcbRackBackInput
    {
          public PcbRackBackInput()
          {
          }

           /// <summary>
           /// 描述 : id唯一标识 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "id唯一标识")]           
           [SugarColumn(IsPrimaryKey=true)]
           public string id {get;set;}

           /// <summary>
           /// 描述 : 操作码(B02) 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "操作码(B02)")]           
           public string op_flag {get;set;}

           /// <summary>
           /// 描述 : 设备条码 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "设备条码")]           
           public string device_sn {get;set;}

           /// <summary>
           /// 描述 : 工位SN 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "工位SN")]           
           public string work_sn {get;set;}

           /// <summary>
           /// 描述 : 操作员工号 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "操作员工号")]           
           public string emp_no {get;set;}

           /// <summary>
           /// 描述 : PCB板SN 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "PCB板SN")]           
           public string pro_sn {get;set;}

           /// <summary>
           /// 描述 : 备用 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "备用")]           
           public string box_sn {get;set;}

           /// <summary>
           /// 描述 : 载具SN  
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "载具SN ")]           
           public string con_sn {get;set;}

           /// <summary>
           /// 描述 : 制令单号 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "制令单号")]           
           public int? mo_num {get;set;}

           /// <summary>
           /// 描述 : MAC条码 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "MAC条码")]           
           public string mac_sn {get;set;}

           /// <summary>
           /// 描述 : 节拍（MS） 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "节拍（MS）")]           
           public string rhythm {get;set;}

           /// <summary>
           /// 描述 : 相对路径, 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "相对路径,")]           
           public string img_path {get;set;}

           /// <summary>
           /// 描述 : 创建时间 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建时间")]           
           public DateTime? creation_time {get;set;}

           /// <summary>
           /// 描述 : 更新时间 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "更新时间")]           
           public DateTime? updata_time {get;set;}

    }
}