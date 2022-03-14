<h1 align="center"> CPT-206-Lab-9 </h1>
<h2 align="center">Chapter 9, Exercise #4 - <i>Potter Project / Solution / Potter Jr High</i><br>
Programming with Microsoft Visual Basic 2017, by Diane Zak (8th Edition)</h2>
<hr>
<h3>The Assignment: </h3>
<div>
  <ol type="a">
    <li> The application will display the names of students who have earned the 
      grade selected in a list box. The student names and grades are stored in the 
      NamesAndGrades.txt file. Copy the file from the VB2017\Chap09 folder to the 
      Potter Project’s bin\Debug folder. Now, open the NamesAndGrades.txt file. The file 
      contains 15 names and 15 grades. Close the NamesAndGrades.txt window. </li>
    <li> Create the interface shown in Figure 9-37. Use the String Collection Editor to 
enter the five grades in the lstGrades control. Change the lstNames control’s 
      SelectionMode and Sorted properties to None and True, respectively </li>
    <li> Code the Exit button’s Click event procedure. </li>
    <li> The first item in the lstGrades control should be selected when the interface appears. 
Code the appropriate procedure. </li>
    <li> The contents of the lstNames and lblNumber controls should be cleared when a 
      different grade is selected in the lstGrades control. Code the appropriate procedure </li>
    <li> The Display button should display the names of students who have earned the grade 
selected in the lstGrades control. It should also display the number of students who 
have earned that grade. Code the appropriate procedure </li>
    <li> Save the solution and then start and test the application </li>
  </ol>
<br>
  My course has a few additional rules that apply, such as requirements for:
 <ul>
   <li> Splash Screen(s)</li>
   <li> Tool tips </li>
   <li> Clearing values that aren't focused, or when the focus changes, etc </li>
   <li> Time and date </li>
   <li> Form naming conventions (frmMain, Title bar) </li>
   <li> and more useful things to spiff up the form. </li>
  </ul>     
</div>

<h3 align = "center"> Visual example of the program<br><i>(From the text book)</i></h3>

<div align = "center">

![image](https://user-images.githubusercontent.com/67248738/158099974-40f18cae-48b5-4b37-b242-1ea04d90d179.png)

<br>
<a href="https://github.com/charlotte-2222/Charlotte-Childers-CPT-206-Lab-9/blob/master/frmMain.Designer.vb"> Link to the designer Form. </a>
</div>

<h3> My approaches to the assignment: </h3>
<div>
  Out the gate, I knew there may be an issue regarding the file reading (from the UX side of things.)
    As found <a href="https://github.com/charlotte-2222/Charlotte-Childers-CPT-206-Lab-9/blob/master/frmMain.vb"> here </a> on line 48, 
    the program mostly centers around one thing.
</div>
<br>
<br>
  <div align = "center">
    <img src="https://user-images.githubusercontent.com/67248738/158102116-b474d8bf-da0f-4a81-8628-81ba233603ee.png">
<br>
  </div>
<br>

<div>
    Simple enough right? (it really is, I made it harder than it should be.)
    The problem is that the text file is included with the debug folder of the program, and if not? Well there's an exception, unless you account for it.
    I had to figure out a way to account for this, 
    and my preferred outcome was: <i>If it cant be found, or there is an issue reading the file - let the user pick one.</i> 
  </div>
<br>

  <h4> So here is what I started doing (after a bit of trouble): </h4><br>

<div align ="center">
  <p>
    I assigned a variable to a message box. (ln. 40)
<br>
  </p>
    <img src="https://user-images.githubusercontent.com/67248738/158101946-6e07c269-2029-4346-9102-d46bf3344a30.png">
<br>
  <p>
    I later used this to make an if/else condition based on the failure of the initial text file load.
    (lots of nested if/elses, i'm sure theres a better way - but I spent a while doing this and couldn't find one)
<br>
  </p>
    <img src="https://user-images.githubusercontent.com/67248738/158102001-904f65c4-e910-429a-968f-1e4a1c613c9e.png">
<br>
</div>

<h4> From there </h4>
<div>
  <p>
    At this point, once i'd completed all the "error catching" methodology that I felt was necessary,
    I moved on to polishing the rest of the program, and double checking, then triple-checking the program for bugs. Hopefully none are present.
    <br>
  </p><br>
  
</div>

<div>  
<strong> At the end of the day I: </strong>
  <ul>
      <li> A decent way to assign variables to message boxes </li>
      <li> Manipulate those message boxes in particular, their button submissions </li>
      <li> Strengthed my understanding of sequential access files and error handling therein </li>
  </ul>

</div>

<div align ="right"> <i>~Charlotte</i></div>
