using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assignment01 {
    class Program {
		private const int LARGEST_VALUE = 20;
		private const int COLUMN_WIDTH = 10;
		private const int NUMBER_OF_COLUMNS = 3;
		private static string divider = new String ('-', COLUMN_WIDTH); 

		static void Main(){

			int[] totalSums = { 0, 0, 0 };

			//string divider = new String ('-', COLUMN_WIDTH); 
			Printer printer = new Printer (COLUMN_WIDTH, NUMBER_OF_COLUMNS);
			Console.WriteLine (printer.ToString (NumberTriplet.TITLES));
			Console.WriteLine (printer.ToString(divider));

			for (int i = 0; i <= LARGEST_VALUE; i += 2) {
				NumberTriplet triplet = new NumberTriplet (i);
				triplet.AddFirstElementsToArray ( totalSums);
				Console.WriteLine (printer.ToString (triplet.GetElements()));

			}
			Console.WriteLine (printer.ToString(divider));
			Console.WriteLine (printer.ToString (totalSums));

        }
    }
}

