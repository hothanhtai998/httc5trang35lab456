using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HoThanhTai_baiLab456.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationDbContext Lecturer { get; set; }
        [Required]
        [StringLength(255)]
        public string LecturedId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}