using System;
 
 namespace DomainContext.DataAccess.Models 
{ 

     public interface Ikontrak  
   {
         int KotrakId {  get; set;} 

         int KelasId {  get; set;} 

         string ItemKontrak {  get; set;} 

         double Bobot {  get; set;} 

     }
}


