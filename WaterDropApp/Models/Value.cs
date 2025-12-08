using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WaterDropApp.Models
{
    namespace WaterDropApp
    {
        //[PrimaryKey(nameof(reg1Value), nameof(regDate))]
        public class Value
        {
            //TODO [key]
            public int Id { get; set; }
            public double? reg1Value { get; set; }
            public DateTime? regDate { get; set; }
            public string valueTypeDescription { get; set; }
            public string valueTypeUnit { get; set; }
        }
    }
}
