using Navigation_Drawer_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Drawer_App.Model
{
    public class Billinput:ClassBase
    {
      

        public DateTime? ContractDate { get => contractDate; set { contractDate = value; OnPropertyChanged(); } }

        public string DisplayName { get => displayName; set { displayName = value; OnPropertyChanged(); } }
        public int Price { get => price; set { price = value; OnPropertyChanged(); } }

        public int Count { get => count; set { count = value; OnPropertyChanged(); } }

        public int TotalMoney { get => totalMoney; set { totalMoney = value; OnPropertyChanged(); } }

        public string Supplier { get => supplier; set { supplier = value; OnPropertyChanged(); } }
        private int price;
        private int count;
        private int totalMoney;
        private Nullable<System.DateTime> contractDate;
        private string displayName;

        private string supplier;
     
    }
}
