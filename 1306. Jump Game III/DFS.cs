public class Solution {
    public bool CanReach(int[] arr, int start) {
       return Helper(arr, start, new bool[arr.Length]); 
    }
    private bool Helper(int[] arr, int current, bool[] visiting){
        if (current >= arr.Length || current < 0 || visiting[current]) return false;
        if (arr[current] == 0) return true;
        visiting[current] = true;
        return Helper(arr, current + arr[current], visiting) 
            || Helper(arr, current - arr[current], visiting);
    }
}