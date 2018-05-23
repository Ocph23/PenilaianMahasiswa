using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocph.DAL;
 
 namespace DomainContext.DataAccess.Models 
{ 
     [TableName("tahunajaran")] 
     public class tahunajaran :BaseNotify, Itahunajaran  
   {
          [PrimaryKey("TahunAjaranId")] 
          [DbColumn("TahunAjaranId")] 
          public int TahunAjaranId 
          { 
               get{return _tahunajaranid;} 
               set{ 

                    SetProperty(ref _tahunajaranid, value);
                     }
          } 

          [DbColumn("Tahun")] 
          public int Tahun 
          { 
               get{return _tahun;} 
               set{ 

                    SetProperty(ref _tahun, value);
                     }
          } 

          [DbColumn("Semester")] 
          public string Semester 
          { 
               get{return _semester;} 
               set{ 

                    SetProperty(ref _semester, value);
                     }
          } 

          private int  _tahunajaranid;
           private int  _tahun;
           private string  _semester;
      }
}


