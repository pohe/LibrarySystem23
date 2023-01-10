using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem23
{
    public class Book:Media
    {
		public string ISBN { get; set; }

		public Book(string isbn, int mediaId, string title, string author, string publisher, int year) :base(mediaId, title, author, publisher, year)
		{
			ISBN = isbn;
		}

		public override string ToString()
		{
			return base.ToString() +  $" || ISBN: {ISBN}";
		}



	}
}
