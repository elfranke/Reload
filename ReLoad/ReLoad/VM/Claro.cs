using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ReLoad.VM
{
   public class Claro: ContentPage
    {
        Button button = new Button
        {
            Text = "Enviar",
            
        };
        Entry hablame = new Entry
        {
            Keyboard = Keyboard.Telephone,
            WidthRequest=180,
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            HorizontalTextAlignment= TextAlignment.Center
        };
        StackLayout Stack = new StackLayout
        {
            Children =
                {
                    new Label
                    {
                        Text="Enviar Hablame",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment= TextAlignment.Center
                    },
            },
            Orientation= StackOrientation.Horizontal
        };
        VM.ListaServicio ilimitado = new VM.ListaServicio(InternetIlimitado);


        public Claro()
        {
            int fz = 24;
            int mg = 5;
            button.Clicked += Button_Clicked;
            Stack.Children.Add(hablame);
            Stack.Children.Add(button);
            Title = "Claro";
            Content = new ScrollView {
                Padding = 0,
                Margin=0,


            Content=
            new StackLayout
            {
                Padding=0,
                Margin=0,
                Children =
                        {
                           new Label
                           {
                               Text="Compra de internet Ilimitado",
                               FontSize=fz,
                               BackgroundColor=Color.Red,
                               Margin=mg,
                               FontAttributes=FontAttributes.Bold,
                               TextColor=Color.White


                           },
                            ilimitado,

                           new Label
                           {
                               Text="Compra de internet por dias",
                               FontSize=fz,
                               BackgroundColor=Color.Red,
                               Margin=mg,
                               FontAttributes=FontAttributes.Bold,
                               TextColor=Color.White


                           },
                            new VM.ListaServicio(InternetDias),

                           new Label
                           {
                               Text="Compra de internet por horas",
                               FontSize=fz,
                               BackgroundColor=Color.Red,
                               Margin=mg,
                               FontAttributes=FontAttributes.Bold,
                               TextColor=Color.White

                           },
                           new VM.ListaServicio(InternetHoras),
                           new Label
                           {
                               Text="Servicios",
                               FontSize=fz,
                               BackgroundColor=Color.Red,
                               Margin=mg,
                               FontAttributes=FontAttributes.Bold,
                               TextColor=Color.White


                           },
                           new VM.ListaServicio(Servicios),
                           Stack

                        },

            }

            ,
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Main m = ilimitado.main();

            string num = hablame.Text;

            if (num.Length > 7)
            {
                string n = string.Format("*200*4*{0}*1#", num);
                if (Device.RuntimePlatform == Device.Android)
                {
                   m.MakePhoneCall(n);
                }
                else
                {
                    PhoneDialer.Open(n);

                }
            }
        }

        private readonly List<Servicio> Servicios = new List<Servicio>
        {

            new Servicio  {   NombreServicio="Consulta de balance", Comando="*122#"  },
            new Servicio  {   NombreServicio="Consulta de internet", Comando="*112*2*1*1#"  },
            new Servicio  {   NombreServicio="Consulta cambiazo prepago", Comando="*111*3*2#"  },
            new Servicio  {   NombreServicio="Préstamo $20", Comando="*200*2*1*1#"  },
            new Servicio  {   NombreServicio="Préstamo $30", Comando="*200*2*2*1#"  },

        };

        private static readonly List<Servicio> InternetIlimitado = new List<Servicio>
        {
            new Servicio  {   NombreServicio="Internet 1 Dia $50", Comando="*112*1*1*1*1#"  },
            new Servicio  {   NombreServicio="Internet 3 Dia $95", Comando="*112*1*1*2*1#" },
            new Servicio  {   NombreServicio="Internet 5 Dia $140", Comando="*112*1*1*3*1#"  },
            new Servicio  {   NombreServicio="Internet 7 Dia $220", Comando="*112*1*1*4*1#"  },
            new Servicio  {   NombreServicio="Internet 10 Dia $270", Comando="*112*1*1*5*1#"  },
            new Servicio  {   NombreServicio="Internet 15 Dia $400", Comando="*112*1*1*6*1#"  },

        };
        private readonly List<Servicio> InternetDias = new List<Servicio>
        {
            new Servicio  {   NombreServicio="Internet 1 Dia 10m $25", Comando="*112*1*2*1*1# "  },
            new Servicio  {   NombreServicio="Internet 1 Dia 100m $40", Comando="*112*1*2*2*1#" },
            new Servicio  {   NombreServicio="Internet 3 Dia 250m $65", Comando="*112*1*2*3*1#"  },
            new Servicio  {   NombreServicio="Internet 5 Dia 350m $100", Comando="*112*1*2*4*1#"  },
            new Servicio  {   NombreServicio="Internet 7 Dia 500m $150", Comando="*112*1*2*5*1#"  },

        };
        private readonly List<Servicio> InternetHoras = new List<Servicio>
        {
            new Servicio  {   NombreServicio="Internet 1 hora 10m $10", Comando="*112*1*3*1*1#"  },
            new Servicio  {   NombreServicio="Internet 3 horas 40m $20", Comando="*112*1*3*2*1#" },
            new Servicio  {   NombreServicio="Internet 7 horas 100m $30", Comando="*112*1*3*3*1# "  },

        };

        private readonly List<Servicio> Otros = new List<Servicio>
        {
            new Servicio  {   NombreServicio="Háblame", Comando="*200*4*tel*1#"  },


        };
    }
}
