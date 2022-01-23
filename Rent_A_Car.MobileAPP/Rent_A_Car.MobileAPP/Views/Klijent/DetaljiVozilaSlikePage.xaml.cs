using Rent_A_Car.MobileAPP.ViewModels.Klijent;
using Rent_A_Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rent_A_Car.MobileAPP.Views.Klijent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetaljiVozilaSlikePage : ContentPage
    {
        private DetaljiVozilaViewModel model = null;
        public DetaljiVozilaSlikePage(Vozilo vozilo)
        {
            InitializeComponent();
            BindingContext = model = new DetaljiVozilaViewModel(vozilo);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }
    }
}