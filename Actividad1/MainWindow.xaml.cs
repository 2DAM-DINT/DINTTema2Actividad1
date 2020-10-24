using System;
using System.Windows;

namespace Actividad1
{
    public partial class MainWindow : Window
    {
        public int NumeroAleatorioGenerado { get; private set; }
        
        public MainWindow()
        {
            InitializeComponent();
            NumeroAleatorioGenerado = GenerarNumeroAleatorio();
        }

        private int GenerarNumeroAleatorio()
        {
            Random semilla = new Random();
            return semilla.Next(0, 101);
        }

        public void Comprobar_Click(object sender, RoutedEventArgs e)
        {
            int numeroElegido = int.Parse(eleccionUsuario.Text);
            if (numeroElegido == NumeroAleatorioGenerado)
                resultado.Text = "¡Has acertado!";
            else if (numeroElegido < NumeroAleatorioGenerado)
                resultado.Text = "Te has quedado corto";
            else
                resultado.Text = "Te has pasado";
        }

        public void Reiniciar_Click(object sender, RoutedEventArgs e)
        {
            NumeroAleatorioGenerado = GenerarNumeroAleatorio();
            eleccionUsuario.Text = "";
            resultado.Text = "";
        }
    }
}
