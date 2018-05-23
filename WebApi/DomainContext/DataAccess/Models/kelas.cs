using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocph.DAL;
 
 namespace DomainContext.DataAccess.Models 
{ 
     [TableName("kelas")] 
     public class kelas :BaseNotify, Ikelas  
   {
          [PrimaryKey("KelasId")] 
          [DbColumn("KelasId")] 
          public int KelasId 
          { 
               get{return _kelasid;} 
               set{ 

                    SetProperty(ref _kelasid, value);
                     }
          } 

          [DbColumn("KodeMatakuliah")] 
          public int KodeMatakuliah 
          { 
               get{return _kodematakuliah;} 
               set{ 

                    SetProperty(ref _kodematakuliah, value);
                     }
          } 

          [DbColumn("NIDN")] 
          public int NIDN 
          { 
               get{return _nidn;} 
               set{ 

                    SetProperty(ref _nidn, value);
                     }
          } 

          [DbColumn("TahunAjaranId")] 
          public int TahunAjaranId 
          { 
               get{return _tahunajaranid;} 
               set{ 

                    SetProperty(ref _tahunajaranid, value);
                     }
          } 

          private int  _kelasid;
           private int  _kodematakuliah;
           private int  _nidn;
           private int  _tahunajaranid;
      }
}


