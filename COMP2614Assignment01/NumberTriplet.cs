using System;

namespace COMP2614Assignment01
{
	public class NumberTriplet{
		public static string[] TITLES = { "number", "square", "cube" };
		private int[] triplet = {0,0,0};

		public NumberTriplet (int baseValue){
			triplet [0] = baseValue;
			triplet [1] = (int) Math.Pow(baseValue, 2);
			triplet [2] = (int) Math.Pow(baseValue, 3);

		}

		public void AddFirstElementsToArray(int[] array){
			int numPoints = array.Length;
			if(numPoints >= triplet.Length){
				for(int i = 0; i < numPoints; i += 1){
					array [i] += triplet [i];
				}
			}
		}
	
			
		public int[] GetElements()
		{
			return triplet;
		}

	
	}
}

