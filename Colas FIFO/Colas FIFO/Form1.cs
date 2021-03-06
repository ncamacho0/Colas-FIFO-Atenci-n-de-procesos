﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_FIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random miProceso = new Random();
        Procesador p1 = new Procesador();

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            int procesadorLibre = 0,contProcesos = 0;
            txtResultados.Text = "";
            txtProcesos.Text = "";

            for (int i = 1; i <= 200; i++)
            {
                if (miProceso.Next(0, 101) <= 25)
                {
                    contProcesos++; 
                    Proceso procesoNuevo = new Proceso();
                    p1.push(procesoNuevo);
                    txtProcesos.Text += "Proceso #" + contProcesos + " con " + procesoNuevo.ciclosProceso + " ciclos " + Environment.NewLine;
                }

                if (p1.verificarProcesos() == null)
                    procesadorLibre++;
                else
                    p1.pop(p1.procesar());                                                        

            }
            txtResultados.Text = "Procesador vacio: " + procesadorLibre + Environment.NewLine + "Procesos pendientes: " + p1.totalProcesosFinal() + Environment.NewLine +  "Ciclos necesarios " + p1.ciclosNesesarios();
        }
    }
}
