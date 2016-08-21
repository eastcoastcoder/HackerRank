//https://www.hackerrank.com/challenges/30-queues-stacks

using System;
using System.Collections.Generic;
using System.IO;

///////////////////
//Start Submission
//////////////////
class Solution {
	Stack<char> s = new Stack<char>();
	Queue<char> q = new Queue<char>();
	
	public void pushCharacter(char ch){
		//pushes character onto stack
		s.Push(ch);
	}
	
	public void enqueueCharacter(char ch){
		//enqueues a character in the queue
		q.Enqueue(ch);
	}
	
	public char popCharacter(){
		//pops and returns character from top of stack
		return s.Pop();
	}
	
	public char dequeueCharacter(){
		//dequeues and returns first character in queue
		return q.Dequeue();
	}
////////////////
//End Submission
////////////////

	static void Main(String[] args) {
		// read the string s.
		//string s = Console.ReadLine();
		string s = "racecar";
		
		// create the Solution class object p.
		Solution obj = new Solution();
		
		// push/enqueue all the characters of string s to stack.
		foreach (char c in s) {
			obj.pushCharacter(c);
			obj.enqueueCharacter(c);
		}
		
		bool isPalindrome = true;
		
		// pop the top character from stack.
		// dequeue the first character from queue.
		// compare both the characters.
		for (int i = 0; i < s.Length / 2; i++) {
			if (obj.popCharacter() != obj.dequeueCharacter()) {
				isPalindrome = false;
				
				break;
			}
		}
		
		// finally print whether string s is palindrome or not.
		if (isPalindrome) {
			Console.Write("The word, {0}, is a palindrome.", s);
		} else {
			Console.Write("The word, {0}, is not a palindrome.", s);
		}
	}
}