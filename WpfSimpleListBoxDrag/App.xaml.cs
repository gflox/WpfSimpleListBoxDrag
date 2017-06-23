using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSimpleListBoxDrag
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		//https://www.developpez.net/forums/d1245909/dotnet/langages/csharp/drag-drop-l-interieur-d-listbox-wpf/
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			new WinInteractor().Show();
		}
	}
}
