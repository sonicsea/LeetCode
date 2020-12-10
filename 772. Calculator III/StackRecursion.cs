class Calculator {
    static int Calculate(string s){
       Stack<int> stack = new Stack<int>();
       int n = 0, result = 0;
       char mathOperator = '+';
       for(int i = 0; i < s.Length; i++){
           if (s[i]>='0' && s[i] <= '9') n = n*10 + (s[i]-'0');
           if (s[i]=='(') {
               int temp = 1, start = ++i;
               while(temp!=0){
                   if (s[i]=='(') temp++;
                   else if (s[i]==')') temp--;
                   i++;
               }
               n = Calculate(s.Substring(start, i - start));
               i--;
           }
           
           if (s[i] == '+' || s[i]=='-' || s[i]=='*' || s[i] == '/' || i == s.Length - 1){
               if (mathOperator=='+') stack.Push(n);
               else if (mathOperator=='-') stack.Push(-n);
               else if (mathOperator=='*') stack.Push(stack.Pop() * n);
               else if (mathOperator=='/') stack.Push(stack.Pop() / n);
               mathOperator = s[i];
               n = 0;
           }
       }
        while(stack.Count > 0) result+=stack.Pop();
        return result;
    }
    static void Main() {
        IList<string> expressions = new List<string>{
            "1+1",
            "6 + 2*524",
            "6 - 8242/2",
            "623 + (423 - 1) * ((2+3) - (823)/(92-7))",
            "(1)",
            "()",
            "(7-1-1-1 + 2*90)",
            "848+29*23-19/1",
            "1-1-1-1-1-1-1-1/1*2*222   m*2",
            "",
            "",
            "",
            "",
            "",
            "",
        };
        foreach(var s in expressions){
            if (!string.IsNullOrEmpty(s)) System.Console.WriteLine(Calculate(s));    
        }
        
    }
}