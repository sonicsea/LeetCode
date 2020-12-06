# [215. Kth Largest Element in an Array.(Medium)](https://leetcode.com/problems/kth-largest-element-in-an-array/)

<h2>Problem</h2>
<p>Find the kth largest element in an unsorted array. Note that it is the kth largest element in the sorted order, not the kth distinct element.</p>

<h2>Analysis</h2>
<p>The problem is to return the kth element starting from the end in the sorted array in ascending order. That means if there's duplicates, then those duplicated also count. 3rd largest element in [1,2,3,3,3,4,5,5,5] is 5, not 3.
<p>The obvious solution is to sort the array, and the return the (num.Length - k)th element. This works! And it should be good to mention during an interview. But since this is a medium level question, expect to do a little more than sorting and returning.</p>
<p>My number one choice is to use SortedList. Why not SortedDictionary? Because SortedList is implemented using array, and SortedDictionary is implemented using Red-Black Tree. This gives SortedList constant time to retrieve elements based on indice. Index-base retrieval is not possible for SortedDictionary, which only uses key-based retrieval, and time complexity is O(log n).</p>

<h2>Algorithm using SortedList</h2>
<ul>
<li>Create a SortedList which store key value pair <int, int>: key => element in the array; value=>element's frenquency. sList</li>
<li>Loop through the SortedList starting from the end using index:</li>
    <ul>
        <li>if k>0, then k = k - sList.Values[i];</li>
        <li>if k<=0, return sList.Keys[i]; //This is a guarantee existing point, because this is give "1<=k<=array length"</li>
    </ul>
</ul>