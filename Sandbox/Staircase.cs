//https://www.hackerrank.com/challenges/staircase
//print " " (n-i times), # (i times)

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	static void Main(String[] args) {
		int n = 6;
		int pad = n-1;
		for(int row = 0; row < n; row++){
			Console.Write("".PadLeft(pad--,' '));
			for(int space = 0; space <= row; space++){
				Console.Write("#");
			}
		Console.Write("\n");
		}
	}
}

