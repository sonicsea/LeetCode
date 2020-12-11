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

Example 1:

Input: expression = "!(f)"
Output: true
Example 2:

Input: expression = "|(f,t)"
Output: true
Example 3:

Input: expression = "&(t,f)"
Output: false
Example 4:

Input: expression = "|(&(t,f,t),!(t))"
Output: false
 

Constraints:

1 <= s.length <= 10^5
2 <= k <= 10^4
s only contains lower case English letters.