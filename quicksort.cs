using System;
using System.Collections.Generic;

//Quicksort using a random pivot point
class quicksort {
	
	public void sort(ref List<int> array, int left, int right) {
		if(left >= right) {
			return;
		}
		
		Random r = new Random();
		int pivot = array[r.Next(left, right)];

		int partitionIndex = this.partition(ref array, left, right, pivot);
		this.sort(ref array, left, partitionIndex-1);
		this.sort(ref array, partitionIndex, right);
	}
	
	public int partition(ref List<int> array, int left, int right, int pivot) {
		while(left <= right) {	
			
			while(array[left] < pivot) {
				left++;
			}
			while(array[right] > pivot) {
				right--;
			}
			
			if(left <= right) {
				this.swap(ref array, left, right);
				
				left++;
				right--;
			}
		}
		
		return left;
	}
	
	public void swap(ref List<int> array, int left, int right) {
		int temp = array[right];
		array[right] = array[left];
		array[left] = temp;
	}
	
	static void Main() {
		List<int> sortMe = new List<int>();
		sortMe.Add(2);
		sortMe.Add(89302);
		sortMe.Add(434);
		sortMe.Add(23);
		sortMe.Add(12);
		sortMe.Add(25);
		sortMe.Add(233);
		sortMe.Add(5542);
		sortMe.Add(22);
		sortMe.Add(23456);
		sortMe.Add(2);
		sortMe.Add(4);
		sortMe.Add(6);
		sortMe.Add(13456);
		sortMe.Add(43456);
		sortMe.Add(53456);
		
		
		quicksort x = new quicksort();
		x.sort(ref sortMe, 0, sortMe.Count-1);
		foreach(int y in sortMe) {
			
			Console.Write(y);
			Console.Write(",");
		}
	}
	
	
}
