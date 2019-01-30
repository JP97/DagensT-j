using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DagensTøj
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}





		private void btn_NT(object sender, RoutedEventArgs e)
		{
			NytTøj nt = new NytTøj();
			nt.Show();
			this.Close();
		}

		private void btn_Overblik(object sender, RoutedEventArgs e)
		{
			Overblik o = new Overblik();
			o.Show();
			this.Close();
		}

		private void btn_LogInd(object sender, RoutedEventArgs e)
		{
			Login li = new Login();
			li.Show();
			this.Close();
		}

		private void btn_FT(object sender, RoutedEventArgs e)
		{
			ForeslåTøj ft = new ForeslåTøj();
			ft.Show();
			this.Close();
		}

		private void btn_WTW(object sender, RoutedEventArgs e)
		{
			WhatToWear wtw = new WhatToWear();
			wtw.Show();
			this.Close();
		}

		private void btn_DTW(object sender, RoutedEventArgs e)
		{
			DareToWear dtw = new DareToWear();
			dtw.Show();
			this.Close();
		}
	}
}
