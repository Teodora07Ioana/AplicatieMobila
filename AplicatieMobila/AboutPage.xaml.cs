using System;
using Microsoft.Maui.Controls;

namespace AplicatieMobila
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void OnScheduleAppointment(object sender, EventArgs e)
        {
            // Navighează la pagina de programare
            await Navigation.PushAsync(new ProgramarePage());
        }
    }
}
