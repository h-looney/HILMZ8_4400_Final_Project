# HILMZ8_4400_Final_Project

Application Name: SchoolKeep
Student Name: Holden Looney
Packages/Libraries Used: N/A
Notes on Application: This application differs slightly from the project proposal. I decided to pursue an alternate route during development, so I wanted to acknowledge that before we get into it. 
  I did not implement unique icons or a search bar. Instead, I chose to implement the task manager because I thought it would be a more useful feature than the features I did not include. 
  I think that my application could probably benefit from the implementation of a search bar, but I think that the task manager was a much better feature for me to spend my time and effort on.

Setup: This application has a simple setup. You want to open the ‘MainWindow.xaml.cs’ file in your IDE and navigate to line 13.
  Find whatever file path you would like to start with and copy and paste it where that FilePath is being set.
  Once you have done this you will be able to save and run or even publish the application to run as a standalone app on your computer. Here’s what it will look like.
 
How to Use File Explorer: This section has the most functionality, as it was the primary focus for this application. 
  Using the file path that is hardcoded into the app it will access that directory and display the folders/files found there.
Return: This button takes you into the direct parent directory from where you currently are, even from the starting point of the application. 
  For example, if you launch the app and are in ‘C:\Users\holde\OneDrive\Documents\INFOTC4400’ and you click the return button it will take you to and display 
  the file path ‘C:\Users\holde\OneDrive\Documents’.
Navigate Into: This button allows you to add the selected folder to your file path and will take you into and display the contents. 
  We’ll just inverse the example from before. If you are in ‘C:\Users\holde\OneDrive\Documents’ and select the file ‘INFTOC4400’ it will add that to your file path then 
  take you into and display the contents of ‘C:\Users\holde\OneDrive\Documents\INFOTC4400’
Create Folder: Using the text box to the left of this button, enter the name of the folder you want to create, and then click the ‘Create Folder’ button. 
  This will create an empty folder inside of the current directory.
Create File: Using the text box to the left of this button, enter the name of the file you would like to create, and then click ‘Create File’. 
  This will create an empty file inside of the current directory. This is kind of cool and accidental, you can actually specify the type of file you want 
  to create by adding ‘.{FileExtension}’ to the end of your file name. It will even create image files, but because it is creating an empty file there is 
  nothing to display if you try to open the image file.
How to Use Homework Assignment: This section is the task manager. Here you will enter the name of your task or homework assignment, you can even include the 
  due date in the name, and it will be added to a listbox that displays all of your tasks.
Add: Using the textbox to the left of this button, enter the name of the task you would like to add to your “to-do” list, then click the ‘Add’ button.
Delete: Select one of the tasks from the display and then click the ‘Delete’ button. The task will then be removed from the list.
