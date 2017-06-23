
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfSimpleListBoxDrag
{
	/// <summary>
	/// Logique d'interaction pour Window1.xaml
	/// </summary>
	public partial class SimpleWindow1 : Window
	{
		//simple variable cahche pour Persons
		Persons pList;
		public SimpleWindow1()
		{
			InitializeComponent();

			//obtient une ref à MyDataSource(voir xaml)
			pList = (Persons)this.listbox1.ItemsSource;
		}
		void s_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (sender is ListBoxItem)
			{
				ListBoxItem draggedItem = sender as ListBoxItem;
				DragDrop.DoDragDrop(draggedItem, draggedItem.DataContext, DragDropEffects.Move);
				draggedItem.IsSelected = true;
				draggedItem.Foreground = Brushes.Red;
			}
		}


		void listbox1_Drop(object sender, DragEventArgs e)
		{
			Person droppedData = e.Data.GetData(typeof(Person)) as Person;
			Person target = ((ListBoxItem)(sender)).DataContext as Person;
			int removedIdx = listbox1.Items.IndexOf(droppedData);
			int targetIdx = listbox1.Items.IndexOf(target);
			if (removedIdx < targetIdx)
			{
				pList.Insert(targetIdx + 1, droppedData);
				pList.RemoveAt(removedIdx);
			}

			else
			{
				int remIdx = removedIdx + 1;
				if (pList.Count + 1 > remIdx)
				{
					pList.Insert(targetIdx, droppedData);
					pList.RemoveAt(remIdx);
				}
			}
		}
	}
}