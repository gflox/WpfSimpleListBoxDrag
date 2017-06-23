using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace WpfSimpleListBoxDrag
{
	public class Person
	{
		public Person()
		{ }

		public Person(string fn, int n, string u)
		{
			this.FirstName = fn;
			this.ID = n;
			this.UriImage = u;
		}

		public string FirstName { get; set; }
		public int ID { get; set; }
		public string UriImage { get; set; }
	}

	public class Persons : ObservableCollection<Person>
	{
		Person p;
		Random rnd = new Random();
		string urImg;
		public Persons()
		{
			for (int i = 0; i < 9; i++)
			{
				urImg = "MesImages/giraffe.jpg";
				p = new Person("MyItem" + (i + 1), rnd.Next(50, 100), urImg);
				this.Add(p);

				urImg = "MesImages/mouse.jpg";
				p = new Person("MyItem" + (i + 1), rnd.Next(50, 100), urImg);
				this.Add(p);

				urImg = "MesImages/ZebrasThree.jpg";
				p = new Person("MyItem" + (i + 1), rnd.Next(50, 100), urImg);
				this.Add(p);

				urImg = "MesImages/zebra.jpg";
				p = new Person("MyItem" + (i + 1), rnd.Next(50, 100), urImg);
				this.Add(p);

			}
		}
	}
}