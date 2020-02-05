using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XFCrashCourse.Models;
using XFCrashCourse.Views;

namespace XFCrashCourse.Views
{
    public partial class HomePage : ContentPage
    {

        public HomePage()
        {
            InitializeComponent();

        }

        async void SignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignUpPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}