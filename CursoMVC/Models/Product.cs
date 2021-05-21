using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Product
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }

        [Display(Name = "Categoria")]
        public int CategoryId { get; set; }

        [Display(Name = "Categoria")]
        public Category Category { get; set; }
    }
}
