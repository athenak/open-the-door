using System;

namespace AssemblyCSharp
{
  public static class Helper
	{
		public static int Clamp(this int num, int min, int max)
		{
			if(num < min) return min;
			if(num > max) return max;
			
			return num;
		}
		
		public static float Clamp(this float num, float min, float max)
		{
			if(num < min) return min;
			if(num > max) return max;
			
			return num;
		}
		
		public static double Clamp(this double num, double min, double max)
		{
			if(num < min) return min;
			if(num > max) return max;
			
			return num;
		}
	}
}

