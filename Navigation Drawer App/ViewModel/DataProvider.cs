using Navigation_Drawer_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Drawer_App.ViewModel
{
    public class DataProvider
    {
        private static DataProvider ins;

        public static DataProvider Ins {
            get
            { 
            if(ins == null)
                {
                    ins = new DataProvider();
                }
                return ins;
            
            }
            set { ins = value;  }
        }
        public QUANLYKHORAUCUEntities DB { get; set; }
        private DataProvider()
        {
            DB = new QUANLYKHORAUCUEntities();
        }





    }
}
