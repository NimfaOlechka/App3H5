using AndroidHelloApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidHelloApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LightOnOffPage : ContentPage
    {
        StylePageController pageController;
        public LightOnOffPage()
        {
            InitializeComponent();
            BindingContext = pageController = new StylePageController();
        }
    }
}