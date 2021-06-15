using System;
using System.ComponentModel.DataAnnotations;

namespace _5H_Zaghini_Mattia.Models
{
   public class UnitaImm
   {
       [Key]
       public int NumeroCivico { get; set; }  //autoinc
       public int Superficie { get; set; }
       public int nPersone { get; set; }
       public int NumeroPiano { get; set; }
       public int FKidCondominio{get;set;}
   }
}
