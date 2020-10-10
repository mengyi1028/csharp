using System;

public class Account
{
    [Flags]
    public enum Access
    {
        Delete = 1,
        Publish = 2,
        Submit = 4,
        Comment = 8,
        Modify = 16,
        Writer = (Access.Submit | Access.Modify),
        Editor = (Access.Delete | Access.Publish | Access.Comment),
        Owner = (Access.Writer | Access.Editor)
    }
    
    public static void Main(string[] args)
    {       
        //Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    }
}
