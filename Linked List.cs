//https://www.hackerrank.com/challenges/30-linked-list

using System;
class Node
{
	public int data;
	public Node next;
	public Node(int d){
		data=d;
		next=null;
	}
		
}
class Solution {
	
///////////////////
//Start Submission
//////////////////
	//The insert function has 2 parameters
    //Pointer to a Node: head 
    //Integer value: data
    public static Node insert(Node head, int data)
	{
        //The constructor for Node has 1 parameter: 
		//Integer value for the data field
		Node newNode = new Node(data);

		//Empty List Case:
		//If the head argument passed to the insert function is null, 
		//then the initial list is empty.
		if(head == null)
			return newNode;

		//Nonempty List Case:
		//Traverse to tail
		Node tail = head;
		while(tail.next != null)
			tail = tail.next;
		
		//Insert at the tail of the linked list referenced by the head parameter
		tail.next = newNode;  
		
		//Console.WriteLine("add" + tail.data);
		//Once the new node is added, return the reference to the head node.
		return head;
    }
////////////////
//End Submission
////////////////

	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
	