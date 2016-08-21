//https://www.hackerrank.com/challenges/funny-string

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
	
	static void Main(String[] args) {
		int T = Convert.ToInt32(Console.ReadLine());

		// Test Cases
		while(T > 0){
			string S = Console.ReadLine();
			String result = "";
			for (int i = 1; i < S.Length; i++){
				if(Math.Abs((int)(S[i]-S[i-1])) != 
				   Math.Abs((int)(S[S.Length-i]-S[S.Length-i-1]))){
					result = "Not Funny";
					break; //Stop evaluating
				}
				else
					result = "Funny";
			}
			Console.WriteLine(result);
			T--; // Move to next Test Case
		}
	}
}

/* 
Sample Input:
2
acxz
bcxz

Sample Output:
Funny
Not Funny
*/