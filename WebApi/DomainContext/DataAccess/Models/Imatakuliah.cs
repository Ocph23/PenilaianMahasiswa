using System;
 
 namespace DomainContext.DataAccess.Models 
{ 

     public interface Imatakuliah  
   {
         int KodeMatakuliah {  get; set;} 

         string Nama {  get; set;} 

         int SKS {  get; set;} 

         string Semester {  get; set;} 

     }
}


