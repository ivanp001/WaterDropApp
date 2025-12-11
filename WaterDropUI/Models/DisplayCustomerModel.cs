using System.ComponentModel.DataAnnotations;

namespace WaterDropAppUI.Models
{
    public class DisplayCustomerModel
    {
        public int? ExternalCode { get; set; }
        [Required]
        public string Name { get; set; }
        public int? MpCode { get; set; }
        public string? Street { get; set; }
        public int? SerialNo { get; set; }
        public List<DisplayValueModel> Values { get; set; } = new List<DisplayValueModel>();
    }
}
