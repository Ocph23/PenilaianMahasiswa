using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocph.DAL;
 
 namespace DomainContext.DataAccess.Models 
{ 
     [TableName("dosen")] 
     public class dosen :BaseNotify, Idosen  
   {
          [PrimaryKey("NIDN")] 
          [DbColumn("NIDN")] 
          public int NIDN 
          { 
               get{return _nidn;} 
               set{ 

                    SetProperty(ref _nidn, value);
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

          [DbColumn("Gender")] 
          public string Gender 
          { 
               get{return _gender;} 
               set{ 

                    SetProperty(ref _gender, value);
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

          private int  _nidn;
           private string  _nama;
           private string  _gender;
           private string  _alamat;
      }
}


