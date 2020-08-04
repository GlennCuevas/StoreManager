using Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMangaer
{
	class Program
	{
		static void Main(string[] args)
		{
			Store store = Core.DAL.StoreRepo.Stores.GetStore(1);
			Console.WriteLine($"Loaded a store.\n ID: {store.ID }\n Name: {store.Name}");
		}
	}
}
