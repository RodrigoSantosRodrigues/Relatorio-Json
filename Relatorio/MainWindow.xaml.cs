using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using Relatorio.controllers;
using Relatorio.serializations;

namespace Relatorio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
        RelatorioController dataJson = new RelatorioController();

		public MainWindow()
		{
			InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string texto = JsonConvert.SerializeObject(dataJson.listJson());
            txt.Text = texto;
                 
		}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string texto = JsonConvert.SerializeObject(dataJson.listJson());

            var lista = JsonConvert.DeserializeObject<List<Data>>(texto);

            string groups = JsonConvert.SerializeObject(dataJson.agrouping(lista));

            agrouped.Text = texto;

        }


        /*
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var lista = JsonConvert.DeserializeObject<List<Data>> (txt.Text);
            listResultado.ItemsSource = lista;

        }
        

        private void listResultado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }*/

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
