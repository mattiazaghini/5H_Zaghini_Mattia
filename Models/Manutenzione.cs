using System;
using System.ComponentModel.DataAnnotations;

namespace _5H_Zaghini_Mattia.Models
{
   public class Manutenzione
   {
       [Key]
       public int IdManutenzione { get; set; }
       public int durataLav { get; set; }
       public int oreLav { get; set; }
       public int costoLav { get; set; }
       public string tipologia { get; set; }
       public DataType inizioLav { get; set; }
       public int FKidCondominio { get; set; }
    
   }
}
