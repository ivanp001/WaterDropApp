using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Library
{
    public class Value
    {
        public double? reg1Value { get; set; }
        public DateTime? regDate { get; set; }
        public string? valueTypeDescription { get; set; }
        public string? valueTypeUnit { get; set; }
    }
}
