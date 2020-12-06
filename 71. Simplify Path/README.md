# [71. Simplify Path (Medium)](https://leetcode.com/problems/simplify-path/)

<h2>Problem</h2>
<p>Given an absolute path for a file (Unix-style), simplify it. Or in other words, convert it to the canonical path.</p>
<p>In a UNIX-style file system, a period '.' refers to the current directory. Furthermore, a double period '..' moves the directory up a level.</p>
<p>Note that the returned canonical path must always begin with a slash '/', and there must be only a single slash '/' between two directory names. The last directory name (if it exists) must not end with a trailing '/'. Also, the canonical path must be the shortest string representing the absolute path.</p>

<h2>Analysis</h2>
<p>The key point is to get the portions in between each pairs of "/". There are a few cases to notice</p>
<ul>
    <li>Portion = "..". --- Pop stack, previous "/xxxxx" </li>
    <li>Portion = "." -- ignore</li>
    <li>Portion = "", empty string when 2 or more "/" right next to each other -- ignore</li>
    <li>All other cases -- Push "/"+Portion to stack</li>
</ul>
