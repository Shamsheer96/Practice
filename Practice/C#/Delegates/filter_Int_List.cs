using System;
using System.Collections.Generic;

delegate bool IntFilter(int num);

public class Test
{
    static bool IsEven(int num) => num % 2 == 0;
    
    static List<int> FilterList(List<int> numbers, IntFilter filter){
        List<int> result = new List<int>();
        foreach(int number in numbers){
            if(filter(number)){
                result.Add(number);
            }
        }
        return result;
    }
    
	public static void Main()
	{
	    List<int> numbers = new List<int> {5, 6, 2, 4 ,7 ,9 ,11, 13, 18, 19, 14, 17};
	    List<int> evens = FilterList(numbers, IsEven);
	    
	    Console.WriteLine(string.Join(", ",evens));
	}
}
