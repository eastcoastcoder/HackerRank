//https://www.hackerrank.com/challenges/30-abstract-classes

using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
	
	protected String title;
	protected  String author;
	
	public Book(String t,String a){
		title=t;
		author=a;
	}
	public abstract void display();


}

///////////////////
//Start Submission
//////////////////
//Write MyBook class
class MyBook: Book
{
	protected int price;
	
	public MyBook(string t, string a, int p) : base(t, a)
	{
		price = p;
	}
	public override void display()
	{
		Console.WriteLine("Title: " + title);
		Console.WriteLine("Author: " + author);
		Console.WriteLine("Price: " + price);
	}
}
////////////////
//End Submission
////////////////

class Solution {
	static void Main(String[] args) {
		String title=Console.ReadLine();
		String author=Console.ReadLine();
		int price=Int32.Parse(Console.ReadLine());
		Book new_novel=new MyBook(title,author,price);
		new_novel.display();
	}
}