//https://www.hackerrank.com/challenges/30-inheritance

using System;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

///////////////////
//Start Submission
//////////////////
class Student : Person{
	private int[] testScores;  
	
	public Student(string firstName, string lastName, int id, int[] testScores) : base(firstName, lastName, id)
	{
		/* Inherited
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = id;
		*/
		this.testScores = testScores;
	}
	
	public char calculate()
	{
		int a = 0;
		foreach (int temp in testScores){
			a += temp;
		}
		a = a/testScores.Length;
		if (a >= 90 && a <= 100)
			return 'O';
		if (a >= 80 && a < 90)
			return 'E';
		if (a >= 70 && a < 80)
			return 'A';
		if (a >= 55 && a < 70)
			return 'P';
		if (a >= 40 && a < 55)
			return 'D';
		if(a < 40)
			return 'T';
		return 'T';
	}
}
////////////////
//End Submission
////////////////

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.calculate() + "\n");
	}
}