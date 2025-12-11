using System.ComponentModel.DataAnnotations;

namespace WaterDropAppUI.Models
{
    public class DisplayValueModel
    {
        [Required]
        public double? reg1Value { get; set; }
        [Required]
        public DateTime? regDate { get; set; }
        public string? valueTypeDescription { get; set; }
        public string? valueTypeUnit { get; set; }
    }
}
