using System;

public class Song
{
    private string name;
    public Song NextSong { get; set; }
 
    public Song(string name)
    {
        this.name = name;
    }
    
    public bool IsRepeatingPlaylist()
    {
        Song slow = this;
        Song fast = this.NextSong;
        
        while(slow!=null && fast!=null)
        {
             if(slow.name == fast.name)
             {
                 return true;
             }
            
            // can't set slow = fast
            slow = slow.NextSong;
            
            // if fast.NextSong!= null then
            // fast = fast.NextSong.NextSong
            fast = fast.NextSong?.NextSong;
        }
       
        return false;
    }
    
    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");
    
        first.NextSong = second;
        second.NextSong = first;
    
        Console.WriteLine(first.IsRepeatingPlaylist());
    }
}
