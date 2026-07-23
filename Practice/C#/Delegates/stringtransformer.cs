using System;
using System.Collections.Generic;

delegate string StringTransformer(string input);

public class Test
{
    static string ToUpperCase(string input) => input.ToUpper();
    static string ToLowerCase(string input) => input.ToLower();
    
    static void ProcessNames(List<string> names, StringTransformer transformer){
        foreach(string name in names){
            Console.WriteLine(transformer(name));
        }
    }
    
	public static void Main()
	{
	    /*StringTransformer st = ToUpperCase;
	    Console.WriteLine(st("Martin"));
	    
	    st = ToLowerCase;
	    Console.WriteLine(st("Martin"));*/
	    
	    List<string> names = new List<string> {"Martin", "Napolean", "Winston"};
	    ProcessNames(names, ToUpperCase);
	    ProcessNames(names, ToLowerCase);
	}
}
