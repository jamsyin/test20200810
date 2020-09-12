using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JLQStudent.Models.Enums
{
    public enum  MajorEnum
    {
       [Display(Name ="未分配")]
        None,
       [Display(Name ="计算机科学")]
        ComputerScience,
        [Display(Name = "环境工程")]
        EnvironmentEngine,
        [Display(Name = "通信与信息系统")]
        Communication
    }
}
