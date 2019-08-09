using System.Collections.Generic;
using System;

class StockMerchant
{




	// Complete the sockMerchant function below.
	static int stockMerchant(int n, int[] ar)
	{

		// Hash set to check the combination 
		HashSet<int> mySet = new HashSet<int>();
		// pair count 
		int pairs = 0;

		// Firstly add constariant around N
		if (n >= 1 && n <= 100)
		{
			// Now loop through the array elements lineraly add keep on adding them
			// into hash set 
			foreach (int i in ar)
			{
				// validate constarint on each array element
				if (i >= 1 && i <= 100)
				{
					// check if that element is there in hash set 
					if (mySet.Contains(i))
					{
						// increment the count
						pairs++;
						// now remove the matched pair
						mySet.Remove(i);

					}
					else
					{
						mySet.Add(i);

					}

				}
				else
				{
					return 0;
				}
			}

			return pairs;


		}
		else
		{
			return 0;
		}


	}

	static void Main(string[] args)
	{
		//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
		;
		int result = stockMerchant(n, ar);

		Console.WriteLine(result);

		Console.ReadLine();
	}
}
