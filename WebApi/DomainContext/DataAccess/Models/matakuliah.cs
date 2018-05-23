using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocph.DAL;
 
 namespace DomainContext.DataAccess.Models 
{ 
     [TableName("matakuliah")] 
     public class matakuliah :BaseNotify, Imatakuliah  
   {
          [PrimaryKey("KodeMatakuliah")] 
          [DbColumn("KodeMatakuliah")] 
          public int KodeMatakuliah 
          { 
               get{return _kodematakuliah;} 
               set{ 

                    SetProperty(ref _kodematakuliah, value);
                     }
          } 

          [DbColumn("Nama")] 
          public string Nama 
          { 
               get{return _nama;} 
               set{ 

                    SetProperty(ref _nama, value);
                     }
          } 

          [DbColumn("SKS")] 
          public int SKS 
          { 
               get{return _sks;} 
               set{ 

                    SetProperty(ref _sks, value);
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

          private int  _kodematakuliah;
           private string  _nama;
           private int  _sks;
           private string  _semester;
      }
}


