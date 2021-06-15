using System;
using System.ComponentModel.DataAnnotations;

namespace _5H_Zaghini_Mattia.Models
{
   public class Condominio
   {
       [Key]
       public int CondominioId { get; set; }
       public string Nome { get; set; }
       public int Piani { get; set; }
    
   }
}
