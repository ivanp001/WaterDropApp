using System.ComponentModel.DataAnnotations;

namespace WaterDropAppUI.Models
{
    public class DisplayValueModel
    {
        [Required]
        public double? Reg1Value { get; set; }
        [Required]
        public DateTime? RegDate { get; set; }
        public string? ValueTypeDescription { get; set; }
        public string? ValueTypeUnit { get; set; }
    }
}
