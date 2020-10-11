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
Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not. <br/><br/>

For example, the following code prints "True" as both songs point to each other.<br/>

Song first = new Song("Hello");<br/>
Song second = new Song("Eye of the tiger");<br/>
    
first.NextSong = second;<br/>
second.NextSong = first;<br/>

Console.WriteLine(first.IsRepeatingPlaylist());<br/>
<br/><br/>
[Solution-Song.cs](https://github.com/mengyi1028/csharp/new/main/Song.cs)

<h3>3. AlertService </h3>
Refactor the AlertService and AlertDAO classes:<br/><br/>
Create a new interface, named IAlertDAO, that contains the same methods as AlertDAO.<br/>
AlertDAO should implement the IAlertDAO interface.<br/>
AlertService should have a constructor that accepts IAlertDAO.<br/>
The RaiseAlert and GetAlertTime methods should use the object passed through the constructor.<br/><br/>

[Solution-AlertService.cs](https://github.com/mengyi1028/csharp/blob/main/AlertService)
<h3>4. Merge Name </h3>
Implement the UniqueNames method. When passed two arrays of names, it will return an array containing the names that appear in either or both arrays. The returned array should have no duplicates. <br/><br/>
For example, calling MergeNames.UniqueNames(new string[]{'Ava', 'Emma', 'Olivia'}, new string[]{'Olivia', 'Sophia', 'Emma'}) should return an array containing Ava, Emma, Olivia, and Sophia in any order.
<br/>

[Solution-MergeNames.cs](https://github.com/mengyi1028/csharp/blob/main/MergeNames)

<h3>5. User Input</h3>
 User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.<br/>

Implement the class TextInput that contains:<br/>
    <ul>
    <li>Public method void Add(char c) - adds the given character to the current value</li>
    <li>Public method string GetValue() - returns the current value</li>
    </ul>
Implement the class NumericInput that:<br/>
<ul>
    <li>Inherits TextInput</li>
    <li>Overrides the Add method so that each non-numeric character is ignored</li>
    </ul>
    <br/>

[Solution-UserInput.cs](https://github.com/mengyi1028/csharp/blob/main/UserInput.cs)

<h3>6. Two Sum</h3>
Write a function that, when passed a list and a target sum, returns, efficiently with respect to time used, two distinct zero-based indices of any two of the numbers, whose sum is equal to the target sum. If there are no two numbers, the function should return null.<br/><br/>

For example, FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10) should return a Tuple<int, int> containing any of the following pairs of indices:
    <ul>
        <li>0 and 3 (or 3 and 0) as 3 + 7 = 10</li>
        <li>1 and 5 (or 5 and 1) as 1 + 9 = 10</li>
        <li>2 and 4 (or 4 and 2) as 5 + 5 = 10</li>
    </ul>
[Solution-TwoSum.cs](https://github.com/mengyi1028/csharp/blob/main/TwoSum.cs)

<h3>7. Quadratic Equation</h3>
Implement the FindRoots function to find the roots of the quadratic equation: ax2 + bx + c = 0. If the equation has only one solution, the function should return that solution as both elements of the tuple. The equation will always have at least one solution.<br/><br/>

For example, the roots of the equation 2x2 + 10x + 8 = 0 are -1 and -4.<br/><br/>
[Solution-QuadraticEquation.cs](https://github.com/mengyi1028/csharp/blob/main/QuadraticEquation.cs)
