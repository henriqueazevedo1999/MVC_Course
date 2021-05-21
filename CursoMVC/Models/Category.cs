using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Category
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo é obrigatório")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Produtos")]
        public List<Product> Products { get; set; }
}
}
