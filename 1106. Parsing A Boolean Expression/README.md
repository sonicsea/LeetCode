# [1106. Parsing A Boolean Expression. (Hard)](https://leetcode.com/problems/parsing-a-boolean-expression/)

<p>Return the result of evaluating a given boolean expression, represented as a string.</p>

<p>An expression can either be:</p>
<ul>
<li>"t", evaluating to True;</li>
<li>"f", evaluating to False;</li>
<li>"!(expr)", evaluating to the logical NOT of the inner expression expr;</li>
<li>"&(expr1,expr2,...)", evaluating to the logical AND of 2 or more inner expressions expr1, expr2, ...;</li>
<li>"|(expr1,expr2,...)", evaluating to the logical OR of 2 or more inner expressions expr1, expr2, ...</li>
</ul>

Constraints:
<ul>
<li>1 <= expression.length <= 20000</li>
<li>expression[i] consists of characters in {'(', ')', '&', '|', '!', 't', 'f', ','}.</li>
<li>expression is a valid expression representing a boolean, as given in the description.</li>
</ul>

<p>&nbsp;</p>

<p>Example 1:</p>

Input: expression = "!(f)"<br>
Output: true
<p>Example 2:</p>

Input: expression = "|(f,t)"<br>
Output: true
<p>Example 3:</p>

Input: expression = "&(t,f)"<br>
Output: false
<p>Example 4:</p>

Input: expression = "|(&(t,f,t),!(t))"<br>
Output: false
 
