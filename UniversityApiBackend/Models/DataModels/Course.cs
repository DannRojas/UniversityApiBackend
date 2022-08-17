using System.ComponentModel.DataAnnotations;
using UniversityApiBackend.Enums;

namespace UniversityApiBackend.Models.DataModels
{
    public class Course: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required, StringLength(1000)]
        public string LongDescription { get; set; } = string.Empty;

        [Required]
        public string TargetAudences { get; set; } = string.Empty;

        [Required]
        public string Objective { get; set; } = string.Empty;

        [Required]
        public string Requirements { get; set; } = string.Empty;

        [Required]
        public LevelEnum level { get; set; }
    }
}
