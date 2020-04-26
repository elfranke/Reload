using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace ReLoad.VM
{


    public class ListaServicio : ListView
    {
        public ListaServicio(List<Servicio> servicios)
        {
            ItemsSource = servicios;
            ItemTemplate = new DataTemplate(typeof(VLServicios));
            ItemSelected += ListaServicio_ItemSelected;
            Margin = 0;
            HeightRequest = servicios.Count * 45;

        }

        public void ListaServicio_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Main m = main();
            m.ListaServicio_ItemSelected(sender, e);
        }
        public  Main main()
        {
            return Parent.Parent.Parent.Parent as Main;
        }
    }



    internal class VLServicios : ViewCell
    {
        public VLServicios()
        {
            Label Nombre = new Label();
            Label Comando = new Label();
            StackLayout layout = new StackLayout();
            //stile
            Nombre.Margin = new Thickness(10, 10, 10, 0);
            Nombre.FontSize = 18;
            Nombre.FontAttributes = FontAttributes.Bold;

            Comando.Margin = new Thickness(10, 10, 10, 0);
            Comando.FontSize = 18;
            Comando.FontAttributes = FontAttributes.Bold;

            layout.MinimumHeightRequest = 60;
            layout.Orientation = StackOrientation.Horizontal;
            //bindings
            Nombre.SetBinding(Label.TextProperty, "NombreServicio");
            Comando.SetBinding(Label.TextProperty, "Comando");
            // adding to layout
            layout.Children.Add(Nombre);
            //layout.Children.Add(Comando);

            View = layout;

        }
    }

    //public  class VmCompania
    //  {
    //      public static void AddValue(string key, string value)
    //      {
    //          Preferences.Set(key, value);
    //      }

    //      public static string GetValue(string key)
    //      {
    //          return Preferences.Get(key, "");
    //      }

    //      public static void DelValue(string key)
    //      {

    //          Preferences.Remove(key);
    //      }
    //  }


    //internal class Companias : ContentPage
    //{   
    //    public Companias()
    //    {
    //        Content = new StackLayout
    //        {
    //            Children =
    //            {
    //                new Lista()
    //            },

    //        };
    //        Title= "Resumen";


    //    }


    //}

    //public class Lista : ListView
    //{
    //    public Lista()
    //    {
    //        ItemsSource = Compania.Lcompania;
    //        ItemTemplate = new DataTemplate(typeof(VLCompanias));
    //        ItemSelected += Lista_ItemSelected;

    //    }

    //    private void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    //    {

    //        Compania item = e.SelectedItem as Compania;

    //       //VmCompania. AddValue("Idc", item.IDCompania.ToString());
    //       // string c= VmCompania.GetValue("Idc");
    //        Main m = Parent.Parent.Parent as Main;
    //        m.Children.RemoveAt(0);
    //        //m.Children.Add(new Individual(c));
    //        //m.Children.Add(new Programado(c));
    //    }

    //}

    //internal class VLCompanias : ViewCell
    //{
    //    public VLCompanias()
    //    {
    //        var img = new Image();
    //        Label Nombre = new Label();
    //        StackLayout layout = new StackLayout();
    //        //stile
    //        Nombre.Margin = new Thickness(10, 10, 10, 0);
    //        Nombre.FontSize = 18;
    //        Nombre.FontAttributes = FontAttributes.Bold;
    //        img.HeightRequest = 80;
    //        img.WidthRequest = 80;
    //        layout.MinimumHeightRequest = 60;
    //        layout.Orientation = StackOrientation.Horizontal;
    //        //bindings
    //        Nombre.SetBinding(Label.TextProperty, "Nombre");
    //        img.SetBinding(Image.SourceProperty, "Img");
    //        // adding to layout
    //        layout.Children.Add(img);
    //        layout.Children.Add(Nombre);

    //        View = layout;

    //    }
    //}



}
