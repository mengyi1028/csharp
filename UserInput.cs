using System;

public class TextInput 
{
    public string value;
    
    // Declared virtual so it can be overridden.
    public virtual void Add(char c)
    {
        value +=c;
    }
    
    public string GetValue()
    {
        return value;
    }
}

public class NumericInput: TextInput
{
    
   // override
    public override void Add(char c)
    {        
        if (Char.IsDigit(c))
        {
            value+=c;
        }
    }
    
    
}

public class UserInput
{
    public static void Main(string[] args)
    {
        //TextInput input = new NumericInput();
        //input.Add('1');
        //input.Add('a');
        //input.Add('0');
        //Console.WriteLine(input.GetValue());
    }
}
