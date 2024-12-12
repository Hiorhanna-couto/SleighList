using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SleighList.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }

        [ForeignKey("Item")]   
         public int ItemID { get ; set;}
         public Item? Item { get ; set;}
        


    }
}