using System;
using System.ComponentModel.DataAnnotations;

namespace _5H_Zaghini_Mattia.Models
{
   public class Consiglieri
   {
       [Key]
       public string codiceF { get; set; }
       public string nome { get; set; }
       public string cognome { get; set; }
       public DataType dataNascita { get; set; }
       public string indirizzo { get; set; }
       public DataType inizioIncarico { get; set; }
    public DataType fineIncarico { get; set; }
       public int FKnumeroCivico { get; set; }
    
   }
}
