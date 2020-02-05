using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFCrashCourse.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        async void CancelClick(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }
    }
}
