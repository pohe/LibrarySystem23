using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem23
{
    public class Patron
    {
		public string Mobile { get; set; }

		private int _year;

		public int Year
		{
			get { return _year; }
			set { _year = value; }
		}


		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _address;

		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		public Patron(string name, string address)
		{
			_name = name;
			_address = address;
		}

		public override string ToString()
		{
			return $"Name {_name} Address {_address}";
		}

	}
}
