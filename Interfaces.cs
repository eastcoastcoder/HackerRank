//https://www.hackerrank.com/challenges/30-interfaces

using System;
public interface AdvancedArithmetic{
	int divisorSum(int n);
}

///////////////////
//Start Submission
//////////////////
//Calculator class, which implements (:) the AdvancedArithmetic interface
class Calculator : AdvancedArithmetic {
	public int divisorSum(int n){
		//return sum of all its divisors
		int sum = 0;
		
		for(int div = 1; div <= n; div++){
			if((n % div) == 0)
				sum += div;
		}
		
		return sum; 
	}
}
////////////////
//End Submission
////////////////
class Solution{
	static void Main(string[] args){
		//int n = Int32.Parse(Console.ReadLine());
	  	int n = 6;
		AdvancedArithmetic myCalculator = new Calculator();
		int sum = myCalculator.divisorSum(n);
		Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
	}
}