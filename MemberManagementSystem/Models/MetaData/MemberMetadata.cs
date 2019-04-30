using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MemberManagementSystem.Models
{
    [MetadataType(typeof(MemberMetadata))]

    public partial class Member

    {
        public class MemberMetadata
        {
            [DisplayName("編號：")]
            public int Id { get; set; }
            [DisplayName("姓名：")]
            [StringLength(15, MinimumLength = 3, ErrorMessage = "姓名必須是3到15個字")]
            public string Name { get; set; }
            [DisplayName("年齡：")]
            [Range(0, 120, ErrorMessage = "年齡異常")]
            public int Age { get; set; }
            [DisplayName("地址：")]
            [Required(ErrorMessage = "請輸入地址")]
            [StringLength(50, ErrorMessage = "地址過長")]
            public string Address { get; set; }
            [DisplayName("電話：")]
            [RegularExpression(@"^([0,9]{2})?([0-9]{2})?\-?([0-9]{6})$", ErrorMessage = "Not a valid Phone number")]
            public string Tel { get; set; }
            //09開頭
        }
    }
    
}