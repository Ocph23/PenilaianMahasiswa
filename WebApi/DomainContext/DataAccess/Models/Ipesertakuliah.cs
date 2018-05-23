using System;
 
 namespace DomainContext.DataAccess.Models 
{ 

     public interface Ipesertakuliah  
   {
         int NPM {  get; set;} 

         int KelasId {  get; set;} 

         string NilaiAngka {  get; set;} 

         int PesertaId {  get; set;} 

     }
}


