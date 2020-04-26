using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Java.Net;
using Java.Util;
using Uri = Android.Net.Uri;

namespace ReLoad
{
    public class Main : TabbedPage
    {

        public Main()
        {
            Children.Add(new VM.Claro());
            //Children.Add(new VM.Orange());
            //Children.Add(new VM.Viva());
        }

 

        public   void ListaServicio_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Servicio servicio = e.SelectedItem as Servicio;
            string n = Uri.Encode(servicio.Comando, "UTF-8");
            // DisplayAlert("Alert", servicio.Comando, "OK");
            if (Device.RuntimePlatform == Device.Android)
            {
                MakePhoneCall(servicio.Comando);
            }
            else
            {
                PhoneDialer.Open(n);

            }
        }

        public void MakePhoneCall(string number)
        {
            string n = Uri.Encode(number, "UTF-8");
            var uri = Uri.Parse("tel:" + n);
            Intent intent = new Intent(Intent.ActionCall, uri);
            intent.AddFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(intent);
        }



        //public void RemoveChild()
        //{
        //    Children.RemoveAt(1);
        //}
    }


}