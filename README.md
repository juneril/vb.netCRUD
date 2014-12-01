VB.NET-Desktop-App-Generator
============================

VB.NET Desktop App Generator for creating VB.NET Desktop applications - lets you quickly set up a project with sensible defaults and best practices.

## Project Structure

Overview

    ├── My Project/             - Configuration of the application
    ├── Classes/                - Contains Classes
    ├── Config/                 - Exe. Application configuration on runtime
    │   ├── config.ini/         - Contains configuration of the application
    ├── Dataset/                - Application Datasets
    ├── Forms/                  
    │   ├── Form1.vb            - Optional Form
    │   ├── frmConnector.vb     - Form used to build connection between application and database, connection will be stored on config.ini
    │   ├── frmLogin.vb         - Login Form
    │   ├── frmMain.vb          - This the MDIParent of the application, serve as the parent among all forms.
    │   ├── frmProperties       - Form used to display the database connection properties
    ├── Images/                 - Contains Images requires in the application
    ├── Modules/                - Contains all the Module files
    │   ├── modConnection.vb    - Contains code to initialize the app configuration, database connection and application execution
    │   ├── modEmployees.vb     - (Optional) Contains Controller Code for Employees
    │   ├── modFunctions.vb/    - Contains custom made functons and procedures for easy and faster development
    │   ├── modINIParser.vb/    - This parses the values in a particular .INI file
    ├── Reports/                - Contains Reports
    │   ├── rtpSample.rpt       - include Sample reports
    ├── App.config              - Application configuration


## Git Workflow ##

**Clone the repo**

```
#!javascript

git clone url_repo
```


**Get the latest development branch**


```
#!javascript

git fetch
git checkout development
git pull origin development
```


**Create a local branch - This will be used to merge, pull, and push to the remote branch**


```
#!javascript

git checkout -b <your_name_branch> origin/development
```


**Create a feature branch. Please name your branch like "feature/login_form"**


```
#!javascript

git checkout -b origin/<your_name_branch>
```


**After you develop your feature branch (be sure you have commit all the code) checkout your local branch and pull from remote. Then merge you feature  branch **


```
#!javascript

git checkout <your_name_branch>
git pull origin development
git merge --no-ff <feature_branch>
```


Note: Be sure that check the code. If in case there is conflict please resolve before pushing it.

**Push your code to remote **


```
#!javascript

git push origin <your_name_branch>
```


**Create Merge/Pull request to development branch**

* Please Do Not Approve or merge your create merge request. It needs to review first before it will be merge