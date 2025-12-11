using System.ComponentModel.DataAnnotations;

namespace DataAccess.Library
{
    public class Customer
    {
        public int ExternalCode { get; set; }
        public string Name { get; set; }
        public int? MpCode { get; set; }
        public string? Street { get; set; }
        public int? SerialNo { get; set; }
        public List<Value>? Values { get; set; } = new List<Value>();
    }
}
