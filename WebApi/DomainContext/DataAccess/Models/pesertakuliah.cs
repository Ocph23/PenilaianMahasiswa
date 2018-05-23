using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocph.DAL;
 
 namespace DomainContext.DataAccess.Models 
{ 
     [TableName("pesertakuliah")] 
     public class pesertakuliah :BaseNotify, Ipesertakuliah  
   {
          [DbColumn("NPM")] 
          public int NPM 
          { 
               get{return _npm;} 
               set{ 

                    SetProperty(ref _npm, value);
                     }
          } 

          [DbColumn("KelasId")] 
          public int KelasId 
          { 
               get{return _kelasid;} 
               set{ 

                    SetProperty(ref _kelasid, value);
                     }
          } 

          [DbColumn("NilaiAngka")] 
          public string NilaiAngka 
          { 
               get{return _nilaiangka;} 
               set{ 

                    SetProperty(ref _nilaiangka, value);
                     }
          } 

          [PrimaryKey("PesertaId")] 
          [DbColumn("PesertaId")] 
          public int PesertaId 
          { 
               get{return _pesertaid;} 
               set{ 

                    SetProperty(ref _pesertaid, value);
                     }
          } 

          private int  _npm;
           private int  _kelasid;
           private string  _nilaiangka;
           private int  _pesertaid;
      }
}


