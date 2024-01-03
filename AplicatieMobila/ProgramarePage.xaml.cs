using System;
using Microsoft.Maui.Controls;
using AplicatieMobila.Models;
using System.Collections.ObjectModel;

namespace AplicatieMobila
{
   

    public partial class ProgramarePage : ContentPage
    {
        public ObservableCollection<Programare> ProgramarileUtilizatorului { get; set; } = new ObservableCollection<Programare>();

        public ProgramarePage()
        {
            InitializeComponent();
            // Inițializați și populați aici controalele, de exemplu servicePicker
            servicePicker.SelectedIndexChanged += OnServiceSelected;
           
        }

        private void OnServiceSelected(object sender, EventArgs e)
        {
            var selectedService = servicePicker.SelectedItem as string;
            // Implementați logica pe care doriți să o testați atunci când este selectat un serviciu
            Console.WriteLine($"Serviciul selectat: {selectedService}");
        }
        private async void OnConfirmAppointment(object sender, EventArgs e)
        {
            await DisplayAlert("Confirmare", "Programare făcută cu succes!", "OK");
            var nouaProgramare = new Programare
            {
                Serviciu = servicePicker.SelectedItem.ToString(),
                Data = datePicker.Date,
                Ora = timePicker.Time
            };

            // Presupunem că avem o clasă statică sau un serviciu singleton pentru a menține programările
            ProgramariService.AddProgramare(nouaProgramare);

            // Afișează un mesaj de confirmare

            // Logica pentru confirmarea programării
            // Exemplu: colectarea datelor și trimiterea lor la un server sau stocarea într-o bază de date




        }
    }
}
