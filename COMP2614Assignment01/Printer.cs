using System;

namespace COMP2614Assignment01
{
	public class Printer
	{
		private int columnWidth;
		private int numberOfColumns;
		private string formatString;
	

		public Printer (int columnWidth, int numberOfColumns )
		{
			this.columnWidth = columnWidth;
			this.numberOfColumns = numberOfColumns;

		}


		private void addElementToFormatString(int index){
			formatString = String.Format ("{0}{1}{2}, {3}{4}", formatString, "{", index, columnWidth, "}");

		} 

		private void makeAllColumnsFormatString(){
			formatString = "";
			for (int i = 0; i < numberOfColumns; i++) {
				addElementToFormatString (i);
			}

		}

		private string addElementToOutput(string output, Object element)
		{
			string newElementFormatString = String.Format("{0}{1}, {2}{3}", "{", 0, columnWidth, "}");
			string newElementOutput = String.Format (newElementFormatString, element);
			output = String.Format ("{0}{1}", output, newElementOutput);
			return output;
		}

		public string ToString(string[] elements)
		{
			string output = "";
			for(int i = 0; i < numberOfColumns; i ++)
			{
				output = addElementToOutput (output, elements [i]);
			}
			return output;
		}

		public string ToString(int[] elements)
		{
			string output = "";
			for(int i = 0; i < numberOfColumns; i ++)
			{
				output = addElementToOutput (output, elements [i]);
			}
			return output;
		}

		public string ToString (string element)
		{
			string output = "";
			for (int i = 0; i < numberOfColumns; i++) {
				output = addElementToOutput (output, element);
			}
			return output;
		}

	


}
}
