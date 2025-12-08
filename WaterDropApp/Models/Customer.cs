using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using WaterDropApp.Data;

namespace WaterDropApp.Models
{
    namespace WaterDropApp
    {
        public class Customer
        {
            [Key]
            public int? ExternalCode { get; set; }
            public int? MpCode { get; set; }
            public string? Name { get; set; }
            public string? Street { get; set; }
            public int? SerialNo { get; set; }
            public List<Value>? Values { get; set; } = new List<Value>();
        }
    }
}
