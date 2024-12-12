using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SleighList.Models
{
    public class Item
    {
        [Key]
       public  int ItemID { get; set;}
    
       public  string? Nome { get; set;}

       public int PrecoUnidade { get; set;}

       public  string? Quantidade { get; set;}
    

    }
}