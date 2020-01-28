using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFCrashCourse.Views
{
    public partial class Button : ContentPage
    {
        public Button()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await button.RelRotateTo(360, 1000);
        }
    }
}
