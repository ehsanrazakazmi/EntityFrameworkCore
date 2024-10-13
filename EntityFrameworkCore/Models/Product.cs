using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCore.Models
{
    public class Product
    {
        //[Key]           // this indicated that Id is primary key if we write any other name instead of Id
        public int Id { get; set; }

        public string Name { get; set; } = null!;       // if we dont declare the name as null then it will give warning

        [Column(TypeName = "decimal(6,2)")]     // price is initialized as point of 2 point of precesion
        public decimal Price { get; set; }
    }
}
