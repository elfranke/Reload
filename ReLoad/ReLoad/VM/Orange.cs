using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ReLoad.VM
{
   public class Orange: ContentPage
    {


        private readonly List<Servicio> Servicios = new List<Servicio>
        {
            new Servicio  {   NombreServicio="Internet 1 Dia", Comando="*122#"  },
            new Servicio  {   NombreServicio="Internet 3 Dia", Comando="*122#" },
            new Servicio  {   NombreServicio="Internet 5 Dia", Comando="*122#"  },

        };

        private readonly List<Servicio> Internet = new List<Servicio>
        {
            new Servicio  {   NombreServicio="Internet 1 Dia", Comando="*122#"  },
            new Servicio  {   NombreServicio="Internet 3 Dia", Comando="*122#" },
            new Servicio  {   NombreServicio="Internet 5 Dia", Comando="*122#"  },

        };

        private readonly List<Servicio> Otros = new List<Servicio>
        {
            new Servicio  {   NombreServicio="Internet 1 Dia", Comando="*122#"  },
            new Servicio  {   NombreServicio="Internet 3 Dia", Comando="*122#" },
            new Servicio  {   NombreServicio="Internet 5 Dia", Comando="*122#"  },

        };
    }

}
