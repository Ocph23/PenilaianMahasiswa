using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocph.DAL;
 
 namespace DomainContext.DataAccess.Models 
{ 
     [TableName("mahasiswa")] 
     public class mahasiswa :BaseNotify, Imahasiswa  
   {
          [PrimaryKey("NPM")] 
          [DbColumn("NPM")] 
          public int NPM 
          { 
               get{return _npm;} 
               set{ 

                    SetProperty(ref _npm, value);
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

          [DbColumn("Angkatan")] 
          public string Angkatan 
          { 
               get{return _angkatan;} 
               set{ 

                    SetProperty(ref _angkatan, value);
                     }
          } 

          [DbColumn("Alamat")] 
          public string Alamat 
          { 
               get{return _alamat;} 
               set{ 

                    SetProperty(ref _alamat, value);
                     }
          } 

          [DbColumn("Gender")] 
          public string Gender 
          { 
               get{return _gender;} 
               set{ 

                    SetProperty(ref _gender, value);
                     }
          } 

          private int  _npm;
           private string  _nama;
           private string  _angkatan;
           private string  _alamat;
           private string  _gender;
      }
}


