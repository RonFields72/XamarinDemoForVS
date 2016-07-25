using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinSetupDemo
{
    public class App : Application
    {
        public App()
        {
            Button btn = new Button();
            btn.Text = "I'm a button, man!";
            btn.Clicked += (sender, args) => {
                btn.Text = "Thanks for clicking me, dude!";
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms from VS 2015!"
                        },
                        btn
                    }
                }
            };
        }

        

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
