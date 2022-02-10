using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFacts.Importer.UI.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public string[] Importers { get; set; }
        public string[] Targets { get; set; }

        private bool isIdle;


        public string SelectedImporter { get; set; }
        public string SelectedExporter { get; set; }

        public bool IsIdle
        {
            get { return isIdle; }
            set { isIdle = value; NotifyPropertyChanged(nameof(IsIdle)); }
        }

        private ViewModelBase? importViewModel;

        public ViewModelBase? ImportViewModel
        {
            get { return importViewModel; }
            set { importViewModel = value; NotifyPropertyChanged(nameof(ImportViewModel)); }
        }

        private ViewModelBase? exportViewModel;

        public ViewModelBase? ExportViewModel
        {
            get { return exportViewModel; }
            set { exportViewModel = value; }
        }

        public MainViewModel()
        {
            Importers = new string[]
            {
                "CSV"
            };

            Targets = new string[]
            {
                "SQL Database"
            };

            IsIdle = true;
            SelectedExporter = "SQL Database";
            SelectedImporter = "CSV";
            ImportViewModel = new FileImportViewModel();
            ExportViewModel = new ConnectionStringViewModel();
        }
    }
}
