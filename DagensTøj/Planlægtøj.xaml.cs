﻿using System;
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
using System.Windows.Shapes;

namespace DagensTøj
{
	/// <summary>
	/// Interaction logic for Planlægtøj.xaml
	/// </summary>
	public partial class Planlægtøj : Window
	{
		public Planlægtøj()
		{
			InitializeComponent();
		}

		private void btn_Return(object sender, RoutedEventArgs e)
		{
			MainWindow mw = new MainWindow();
			mw.Show();
			this.Close();
		}
	}
}
