//https://www.hackerrank.com/challenges/time-conversion

public class Solution {
	public static void main(String[] args) {
		String[] chunks = new java.util.Scanner(System.in).next().split(":");
		if(chunks[2].contains("PM") && Integer.parseInt(chunks[0]) < 12) 
			chunks[0] = Integer.toString(12 + Integer.parseInt(chunks[0]));
		if(chunks[2].contains("AM") && Integer.parseInt(chunks[0]) == 12) 
			chunks[0] = "00";
		
		System.out.println(chunks[0]+":"+chunks[1]+":"+chunks[2].replace("AM","").replace("PM",""));
	}
}