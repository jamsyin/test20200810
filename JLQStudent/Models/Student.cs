using JLQStudent.Models.Enums;
using JLQStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.SignalR;

namespace JLQStudent.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "名字")]
        [Required(ErrorMessage = "请输入名字，名字不能为空"), MaxLength(50, ErrorMessage = "长度不能超过50个字符")]
        public string Name { get; set; }
        [Display(Name = "主修科目")]
        [Required(ErrorMessage = "请选择一门科目")]
        public MajorEnum? Major { get; set; }
        [Display(Name = "电子邮箱")]
        [RegularExpression(@"^[a-z A-Z 0-9_.+-]+@[a-z A-Z 0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "邮箱格式不正确")]
        [Required(ErrorMessage = "请输入邮箱地址")]
        public string Email { get; set; }

        public string PhotoPath { get; set; }
    }
}
