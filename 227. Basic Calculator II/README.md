# [227. Basic Calculator II (Medium)](https://leetcode.com/problems/basic-calculator-ii/)

<h2>Problem</h2>
<p>Given a string s which represents an expression, evaluate this expression and return its value. </p>

<p>The integer division should truncate toward zero.</p>
<p>Constraints:</p>
<ul>
<li>1 <= s.length <= 3 * 105</li>
<li>s consists of integers and operators ('+', '-', '*', '/') separated by some number of spaces.</li>
<li>s represents a valid expression.</li>
<li>All the integers in the expression are non-negative integers in the range [0, 231 - 1].</li>
<li>The answer is guaranteed to fit in a 32-bit integer.</li>
</ul>

<h2>Analysis</h2>
<p>This problem doesn't involve parenthese, so this makes it a medium level. If there's only "+" and "-" in the expression, then simply push all numbers with the sign to the stack. </p>
<ul>
    <li>if the operator before the number, n, is "+" or none (for first number in the string), push(n)</li>
    <li>if the operator before the number, n, is "-", push(-n)</li>
    <li>after iterating through all the characters, sum up all the numbers in the stack</li>
</ul>
<p>When there's "*" and "/", we need to pop out the last number in the stack, times/divide the current number, and push it result back to the stack. Then sum up all the numbers in the stack at the end.</p>