﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Button = System.Windows.Controls.Button;
using ComboBox = System.Windows.Controls.ComboBox;

namespace ProyectoEntregar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int contador = 1;
        private Button cocina = new Button { Content = "Cocina" };
        private Button salon = new Button { Content = "Salon" };

        private List<string> cuartos = new List<string>();
        private List<Button> botones = new List<Button>();


        public MainWindow()
        {
            InitializeComponent();
           
        }


        private void TabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nombre de la habitación:", "Nombre de la habitación", "", -1, -1);
            contador = TControl.Items.Count;
            TabItem ti = new TabItem { Header =nombre  };
            ti.FontSize = 22;
            ti.IsSelected = true;
            ti.FontFamily = new FontFamily("Bernard MT Condensed");
            TControl.Items.Insert(contador-1, ti);
            contador++;
            

        }
    }
}
    

