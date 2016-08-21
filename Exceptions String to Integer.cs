//https://www.hackerrank.com/challenges/30-exceptions-string-to-integer

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

	static void Main(String[] args) {
		//string S = Console.ReadLine();
		string S = "3";
		try
		{
			Console.WriteLine(Int32.Parse(S));
		}
		catch (FormatException)
		{
			Console.WriteLine("Bad String");
		}
	}
}