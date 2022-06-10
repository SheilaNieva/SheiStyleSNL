﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using SheiStyleSNL.Clases;
using Newtonsoft.Json;
using System.Collections;

namespace SheiStyleSNL
{
    public partial class FrmIngresos : Form
    {
        public FrmIngresos()
        {
            InitializeComponent();
            cargar();
            consultaIngresos();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "6vyUU5qV0nzcwGXgtnzkyPvZDBe8ykvBXH6UV53I",
            BasePath = "https://sheistyle-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient clien;

        private void cargar()
        {
            try
            {
                clien = new FireSharp.FirebaseClient(ifc);

            }
            catch (Exception)
            {

                throw; //no internet connection
            }
        }

        private void consultaIngresos()
        {
            ArrayList listaCantidadIngreso = new ArrayList();
            float cantIngreso = 0;
            FirebaseResponse res = clien.Get(@"Ingreso");
            Dictionary<string, Ingreso> data = JsonConvert.DeserializeObject<Dictionary<string, Ingreso>>(res.Body.ToString());
            foreach (var item in data)
            {
                cantIngreso = item.Value.cantidad + cantIngreso;
                listaCantidadIngreso.Add(cantIngreso);
            }
            double[] cantGrafico = new double[listaCantidadIngreso.Count];
            double[] tiempoGrafico = new double[listaCantidadIngreso.Count];

            for (int i = 0; i < listaCantidadIngreso.Count; i++)
            {
                cantGrafico[i] = double.Parse(listaCantidadIngreso[i].ToString());
                tiempoGrafico[i] = i;
            }




           /* ArrayList listaCantidadGasto = new ArrayList();
            float cantGasto = 0;
            FirebaseResponse res1 = clien.Get(@"Pedido");
            Dictionary<string, Pedido> data1 = JsonConvert.DeserializeObject<Dictionary<string, Pedido>>(res1.Body.ToString());
            foreach (var item in data1)
            {
                cantGasto = item.Value.importe + cantGasto;
                listaCantidadGasto.Add(cantGasto);
                // listaTiempo.Add(tiempo);
                // tiempo++;
            }
            double[] cantGraficoGasto = new double[listaCantidadGasto.Count];
           // double[] tiempoGrafico = new double[listaCantidadIngreso.Count];

            for (int i = 0; i < listaCantidadGasto.Count; i++)
            {
                cantGraficoGasto[i] = double.Parse(listaCantidadGasto[i].ToString());
                //tiempoGrafico[i] = i;
            }*/

            
             grafIngresos.Plot.AddScatter(tiempoGrafico, cantGrafico);

            grafIngresos.Refresh();

        }

    }
}
