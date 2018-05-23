using System;
 
 namespace DomainContext.DataAccess.Models 
{ 

     public interface Ikelas  
   {
         int KelasId {  get; set;} 

         int KodeMatakuliah {  get; set;} 

         int NIDN {  get; set;} 

         int TahunAjaranId {  get; set;} 

     }
}


