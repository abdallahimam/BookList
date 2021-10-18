using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
	public class BookModel
	{
		public int ID { set; get; }
		public string Name { set; get; }
		public string Author { set; get; }
		public string ISBN { set; get; }
	}
}
