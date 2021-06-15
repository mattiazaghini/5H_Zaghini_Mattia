using System;
using System.ComponentModel.DataAnnotations;

namespace _5H_Zaghini_Mattia.Models
{
   public class Spese
   {
       [Key]
       public int IdSpese { get; set; }
       public int soldiSpese { get; set; }
       public int FKnumeroCivico { get; set; }
    
   }
}
