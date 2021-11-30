using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Navigation_Drawer_App.ViewModel;

namespace Navigation_Drawer_App.Model
{
    public class BillOutput:ClassBase
    {
        public DateTime? OutputDate { get => outputDate; set { outputDate = value; OnPropertyChanged(); } }

        public string DisplayName { get => displayName; set { displayName = value; OnPropertyChanged(); } }
        public int Price { get => price; set { price = value; OnPropertyChanged(); } }

        public int Count { get => count; set { count = value; OnPropertyChanged(); } }

        public int TotalMoney { get => totalMoney; set { totalMoney = value; OnPropertyChanged(); } }

        public string Customer { get => customer; set { customer = value; OnPropertyChanged(); } }
        private int price;
        private int count;
        private int totalMoney;
        private Nullable<System.DateTime> outputDate;
        private string displayName;

        private string customer;
    }
}
