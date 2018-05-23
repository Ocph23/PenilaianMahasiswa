using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocph.DAL;
 
 namespace DomainContext.DataAccess.Models 
{ 
     [TableName("nilai")] 
     public class nilai :BaseNotify, Inilai  
   {
          [DbColumn("KotrakId")] 
          public int KotrakId 
          { 
               get{return _kotrakid;} 
               set{ 

                    SetProperty(ref _kotrakid, value);
                     }
          } 

          [DbColumn("PesertaId")] 
          public int PesertaId 
          { 
               get{return _pesertaid;} 
               set{ 

                    SetProperty(ref _pesertaid, value);
                     }
          } 

          [DbColumn("Nilai")] 
          public double Nilai 
          { 
               get{return _nilai;} 
               set{ 

                    SetProperty(ref _nilai, value);
                     }
          } 

          private int  _kotrakid;
           private int  _pesertaid;
           private double  _nilai;
      }
}


