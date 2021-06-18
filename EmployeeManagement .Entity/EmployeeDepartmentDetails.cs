﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EmployeeManagement_.Entity
{
    public partial class EmployeeDepartmentDetails
    {
        [Key]
        public int Department_Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Department_Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created_Time_Stamp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Updated_Time_Stamp { get; set; }
        public bool Is_Deleted { get; set; }
    }
}