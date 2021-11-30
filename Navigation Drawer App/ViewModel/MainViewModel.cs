using LiveCharts;
using LiveCharts.Wpf;
using Navigation_Drawer_App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Navigation_Drawer_App.ViewModel
{
    

    public class MainViewModel:ClassBase
    {
        public ICommand IBtClose { set; get; }
        private ObservableCollection<Model.Object> listObjects;
        public ObservableCollection<Model.Object> ListObjects { get { return listObjects; } set { listObjects = value; OnPropertyChanged(); } }
        private ObservableCollection<Unit> listUnits;
        public ObservableCollection<Unit> ListUnits { get { return listUnits; } set { listUnits = value; OnPropertyChanged(); } }
        private ObservableCollection<Supplier> listSupplier;
        public ObservableCollection<Supplier> ListSupplier { get { return listSupplier; } set { listSupplier = value; OnPropertyChanged(); } }
        private ObservableCollection<Billinput> listBillInput;
        public ObservableCollection<Billinput> ListBillInput { get { return listBillInput; } set { listBillInput = value; OnPropertyChanged(); } }
        private ObservableCollection<BillOutput> listBillOutputs;
        public ObservableCollection<BillOutput>ListBillOutputs { get { return listBillOutputs; } set { listBillOutputs = value; OnPropertyChanged(); } }

        private string inputStatus;
        private Unit selectedItemUnit;
        public Unit SelectedItemUnit { get => selectedItemUnit;
            set { selectedItemUnit = value;
                OnPropertyChanged(); }

                                            }

        public string InputStatus { get => inputStatus; set { inputStatus = value; OnPropertyChanged(); } }
        private string outputStatus;


        public string OutputStatus { get => outputStatus; set { outputStatus = value; OnPropertyChanged(); } }
       
        private string mainStatus;


        public string MainStatus { get => mainStatus; set { mainStatus = value; OnPropertyChanged(); } }
        private string supplierStatus;


        public string SupplierStatus { get => supplierStatus; set { supplierStatus = value; OnPropertyChanged(); } }
        private string unitStatus;


        public string UnitStatus { get => unitStatus; set { unitStatus = value; OnPropertyChanged(); } }
        private string staticsControlStatus;


        public string StaticsControlStatus { get => staticsControlStatus; set { staticsControlStatus = value; OnPropertyChanged(); } }
        private string objectsStatus;


        public string ObjectsStatus { get => objectsStatus; set { objectsStatus = value; OnPropertyChanged(); } }
        private object selectControl;


        public object SelectControl { get => selectControl; 
            set { selectControl = value;
                if(selectControl != null)
                {
                    string Status = ((FrameworkElement)SelectControl).Name;
                    if (Status == "MainControl")
                    {
                        InputStatus = "Hidden";
                        OutputStatus = "Hidden";
                        ObjectsStatus = "Hidden";
                        StaticsControlStatus = "Hidden";
                        UnitStatus = "Hidden";
                        SupplierStatus = "Hidden";
                        MainStatus = "Visible";
                        InputStatus = "Hidden";

                    }
                    if (Status == "InputControl")
                    {
                        InputStatus = "Hidden";
                        OutputStatus = "Hidden";
                        ObjectsStatus = "Hidden";
                        StaticsControlStatus = "Hidden";
                        UnitStatus = "Hidden";
                        SupplierStatus = "Hidden";
                        MainStatus = "Hidden";
                        InputStatus = "Hidden";

                    }
                    if (Status == "OutputControl")
                    {
                        InputStatus = "Hidden";
                        OutputStatus = "Visible";
                        ObjectsStatus = "Hidden";
                        StaticsControlStatus = "Hidden";
                        UnitStatus = "Hidden";
                        SupplierStatus = "Hidden";
                        MainStatus = "Hidden";
                        InputStatus = "Hidden";

                    }
                    if (Status == "SupplierControl")
                    {
                        InputStatus = "Hidden";
                        OutputStatus = "Hidden";
                        ObjectsStatus = "Hidden";
                        StaticsControlStatus = "Hidden";
                        UnitStatus = "Hidden";
                        SupplierStatus = "Visible";
                        MainStatus = "Hidden";
                        InputStatus = "Hidden";

                    }
                    if (Status == "ObjectControl")
                    {
                        InputStatus = "Hidden";
                        OutputStatus = "Hidden";
                        ObjectsStatus = "Visible";
                        StaticsControlStatus = "Hidden";
                        UnitStatus = "Hidden";
                        SupplierStatus = "Hidden";
                        MainStatus = "Hidden";
                        InputStatus = "Hidden";

                    }
                    if (Status == "UnitControl")
                    {
                        InputStatus = "Hidden";
                        OutputStatus = "Hidden";
                        ObjectsStatus = "Hidden";
                        StaticsControlStatus = "Hidden";
                        UnitStatus = "Visible";
                        SupplierStatus = "Hidden";
                        MainStatus = "Hidden";
                        InputStatus = "Hidden";

                    }
                    if (Status == "StaticControl")
                    {
                        InputStatus = "Hidden";
                        OutputStatus = "Hidden";
                        ObjectsStatus = "Hidden";
                        StaticsControlStatus = "Visible";
                        UnitStatus = "Hidden";
                        SupplierStatus = "Hidden";
                        MainStatus = "Hidden";
                        InputStatus = "Hidden";

                    }


                }
               


                OnPropertyChanged(); } }

        

        public MainViewModel()
        {
            chart();
            LoadUnit();
            LoadObject();
            LoadSupplier();
            LoadBillInput();
            LoadBillOutput();
            IBtClose = new RelayCommand<Window>((p) => { return p == null ? false : true; }, (p) =>
            {
                if(p != null)
                {
                    p.Close();
                }
                
            });


        }
        public void LoadObject()
        {
            ListObjects = new ObservableCollection<Model.Object>(DataProvider.Ins.DB.Objects);


        }
        public void LoadUnit()
        {
            ListUnits = new ObservableCollection<Unit>(DataProvider.Ins.DB.Units);
            

        }
        public void LoadSupplier()
        {
            ListSupplier = new ObservableCollection<Supplier>(DataProvider.Ins.DB.Suppliers);


        }
        public void LoadBillInput()
        {
            ListBillInput = new ObservableCollection<Billinput>();
            var bill = DataProvider.Ins.DB.Inputs;
            foreach (var item in bill)
            {
                Billinput Bill = new Billinput();
                Bill.ContractDate = item.ContractDate;
                Bill.Supplier = item.Supplier.DisplayName;
                Bill.DisplayName = item.Object.DisplayName;
                Bill.Price = item.Price;
                Bill.Count = item.Count;
                Bill.TotalMoney = item.Count * item.Price;
                ListBillInput.Add(Bill);

            }


        }
        public void LoadBillOutput()
        {
            ListBillOutputs = new ObservableCollection<BillOutput>();
            var bill = DataProvider.Ins.DB.Outputs;
            foreach (var item in bill)
            {
                BillOutput Bill = new BillOutput();
                Bill.OutputDate = item.DateOutput;
                Bill.Customer = item.Customer.DisplayName;
                Bill.DisplayName = item.Object.DisplayName;
                Bill.Price = item.Price;
                Bill.Count = item.Count;
                Bill.TotalMoney = item.Count * item.Price;
                ListBillOutputs.Add(Bill);

            }


        }
        //chart
        public Func<Double, string> yformatter { set; get; }
        public SeriesCollection SeriesCollection { set; get; }
        public string[] Lables { set; get; }
        public void chart()
        {
            SeriesCollection = new SeriesCollection()
            {
                new LineSeries(){Title="Doanh thu" , Values = new ChartValues<double>{150, 85 ,150, 250 , 150, 100, 20, 100, 200, 300, 350} },
                new LineSeries(){Title="Chi phí" , Values = new ChartValues<double>{120,90,20, 300, 150, 300, 350, 200, 120, 30, 100}},
                new LineSeries(){Title="Lợi nhuận" , Values = new ChartValues<double>{80, 15 , 200 , 70, 150, 30, 180, 20, 50, 60 ,23} },

            };
            Lables = new[] { "100", "200", "300", "400" };
            yformatter = value => value.ToString();
        }
        

    }
}
