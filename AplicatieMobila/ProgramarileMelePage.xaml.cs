using Microsoft.Maui.Controls;
using System.Collections.Generic;
using AplicatieMobila.Models;
using System.Collections.ObjectModel;


namespace AplicatieMobila
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramarileMelePage : ContentPage
    {
        public ObservableCollection<Programare> Programarile { get; set; } = new ObservableCollection<Programare>();

        public ProgramarileMelePage()
        {
            InitializeComponent();
            Programarile = new ObservableCollection<Programare>();
            LoadProgramarile();
            this.BindingContext = this;
        }

        // Simularea încărcării programărilor pentru exemplu
        private void LoadProgramarile()
        {
            // Încărcați programările dintr-o sursă de date
            // Exemplu:
            Programarile.Add(new Programare { Serviciu = "Tuns", Data = DateTime.Today, Ora = new TimeSpan(14, 0, 0) });
            Programarile.Add(new Programare { Serviciu = "Vopsit", Data = DateTime.Today.AddDays(1), Ora = new TimeSpan(16, 0, 0) });
            // Adăugați alte programări după necesități
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Presupunem că avem o clasă statică sau un serviciu singleton pentru a prelua programările
            var programarileUtilizatorului = ProgramariService.GetProgramarileUtilizatorului();

            // Asigurați-vă că ListView sau CollectionView este actualizat cu programările utilizatorului
            programariListView.ItemsSource = programarileUtilizatorului;
        }
    }

 }

