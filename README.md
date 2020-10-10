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
Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not. <br/>

For example, the following code prints "True" as both songs point to each other.<br/>

Song first = new Song("Hello");<br/>
Song second = new Song("Eye of the tiger");<br/>
    
first.NextSong = second;<br/>
second.NextSong = first;<br/>

Console.WriteLine(first.IsRepeatingPlaylist());<br/>
<br/><br/>
[Solution-Song.cs](https://github.com/mengyi1028/csharp/new/main)

<h3>3.AlertService </h3>
Refactor the AlertService and AlertDAO classes:<br/>
Create a new interface, named IAlertDAO, that contains the same methods as AlertDAO.<br/>
AlertDAO should implement the IAlertDAO interface.<br/>
AlertService should have a constructor that accepts IAlertDAO.<br/>
The RaiseAlert and GetAlertTime methods should use the object passed through the constructor.<br/><br/>

[Solution-AlertService.cs](https://github.com/mengyi1028/csharp/blob/main/AlertService)
