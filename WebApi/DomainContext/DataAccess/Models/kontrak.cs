using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocph.DAL;
 
 namespace DomainContext.DataAccess.Models 
{ 
     [TableName("kontrak")] 
     public class kontrak :BaseNotify, Ikontrak  
   {
          [PrimaryKey("KotrakId")] 
          [DbColumn("KotrakId")] 
          public int KotrakId 
          { 
               get{return _kotrakid;} 
               set{ 

                    SetProperty(ref _kotrakid, value);
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

          [DbColumn("ItemKontrak")] 
          public string ItemKontrak 
          { 
               get{return _itemkontrak;} 
               set{ 

                    SetProperty(ref _itemkontrak, value);
                     }
          } 

          [DbColumn("Bobot")] 
          public double Bobot 
          { 
               get{return _bobot;} 
               set{ 

                    SetProperty(ref _bobot, value);
                     }
          } 

          private int  _kotrakid;
           private int  _kelasid;
           private string  _itemkontrak;
           private double  _bobot;
      }
}


