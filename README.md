# csharp
<h3>1. Account </h3>
Each account on a website has a set of access flags that represent a users access. <br/><br/>
Update and extend the enum so that it contains three new access flags:<br/>
(1) A Writer access flag that is made up of the Submit and Modify flags.<br/>
(2) An Editor access flag that is made up of the Delete, Publish and Comment flags.<br/>
(3) An Owner access that is made up of the Writer and Editor flags.<br/><br/>

[Solution-Account.cs](https://github.com/mengyi1028/csharp/blob/main/Account.cs) 
<br/>
<h3>2. Song </h3>

A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. Otherwise, the playlist will end with the last song which points to null. <br/>
<br/>
Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not. <br/><br/>

For example, the following code prints "True" as both songs point to each other.<br/>

Song first = new Song("Hello");
Song second = new Song("Eye of the tiger");
    
first.NextSong = second;
second.NextSong = first;

Console.WriteLine(first.IsRepeatingPlaylist());
<br/>
[Solution-Song.cs](https://github.com/mengyi1028/csharp/new/main)
