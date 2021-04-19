# Virtual-File-System
## Introduction
This is my submission for CS471 Spring 2021 Project 3. Code is found in cs471-project3 folder.

This project was developed in C# in Visual Studio 2019 using Windows Forms.


## Directions For Use
1. The filesystem starts out a root directory with 3 directories a,b,c. You cannot create directories or files in the root.
2. Navigate to a directory by inputting its name into "Select Directory" and pressing **Step Into**.
3. Create a directory by typing a "Directory Name" and pressing **Create Directory**.
4. Create a file by typing a "File Name" and "Content" and pressing **Create File**.
5. Edit a file by typing a "File Name" and pressing **Open File**. Typing in the large "Content" box will save the text written.
6. Delete a file by typing a "File Name" and pressing **Delete File**.
7. Move up a directory by pressing **Step Out**. This will take you to the directory one level of depth above the current directory.

## Demo Image

![Demo Image](/demo.png)


## FileList
### [Form1.cs](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs): Contains functions for actions taken on the GUI.
#### Relevant Functions
- [StepIntoDirectory(String _name)](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs#L223): Steps into a directory with a chosen name.
- [StepOutofDirectory()](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs#L265): Steps out of a directory to one level of depth up.
- [UpdateAllDirectories()](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs#L174): Updates the Virtual File System display with all current directories and files in the system.
- [createDirectory_Button_Click()](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs#L56): Creates a Directory in the current directory with a chosen name.
- [Create_File_Button_Click()](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs#L89): Creates a File in the current directory with a chosen name.
- [openFile_Button_Click()](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs#L124): Opens a File with a selected name to be edited.
- [filecontent_richTextBox_TextChanged()](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs#L138): Edits the content of a selected File and saves it.
- [deleteFile_button_Click()](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Form1.cs#L152): Deletes a selected file.

### [Directory.cs](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Directory.cs): Contains the *Directory* class that mimics a directory. Contains two linked lists of directories and files.
#### Relevant Functions
- [AddDirectory(Directory d)](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Directory.cs#L44): Adds a directory to the directory list. 
- [RemoveDirectory(int _id)](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Directory.cs#L49): Removes a directory by its ID. Implemented but not referenced.
- [AddFile(File _f)](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Directory.cs#L65): Adds a file to the file list.
- [RemoveFile(String _name)](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Directory.cs#L70): Removes a file by name.
- [DisplayContent()](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/Directory.cs#L86): Displays all the directories and files in the directory. Displayed in the Local Directory View
- [DisplayAllContent()](https://github.com/NBarnesL/Virtual-File-System/blob/c541e6e11313ca48384641260b7f1c67c97ae027/cs471-project3/Directory.cs#L107): Recursive function that displays all directories and files at all levels of depth. Layers of depth are denoted by any number of "-".

### [File.cs](https://github.com/NBarnesL/Virtual-File-System/blob/084fb0e8d03edea2da4cb071a6360db93aa57820/cs471-project3/File.cs): Contains the *File* class that mimics a file. Contains a content string and is identified by name.

### Form1.Designer.cs: Windows form Layout.

### Program.cs: Contains the main function that drives the whole program. Its kind of small since this is OOP.

