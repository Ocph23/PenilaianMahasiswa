using System;
 
 namespace DomainContext.DataAccess.Models 
{ 

     public interface Imahasiswa  
   {
         int NPM {  get; set;} 

         string Nama {  get; set;} 

         string Angkatan {  get; set;} 

         string Alamat {  get; set;} 

         string Gender {  get; set;} 

     }
}


