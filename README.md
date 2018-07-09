# Lab18 UsingAnApi
Consume a handcrafted artisanal API

## Objective
Create a front end MVC ASP.NET Core application that consumes data from
an artisanally handcrafted API.  The API lives [here](http://artisanalapi.azurewebsites.net).

---
## Overview
This deployed front end application will send a request to the end points of the [API](http://artisanalapi.azurewebsites.net),
which targets the appropriate file path.  This file path can either be api/todo,
which will call out to the api for all todo items.  The other call is to api/todolist,
which will call out to the api for all the todo lists..
The recieved data is then extracted within a using statment that implements
.Result to extract the data, which is then deserialized with NewtonSoft.
The deployed site can be found [here](http://useartisanalapi.azurewebsites.net/).

---
## Dependencies
This application runs on .NET Core 2.1, which can be downloaded [here](https://www.microsoft.com/net/download/macos).
Additionally, this app relies on NewtonSoft to parse through JSON objects.

---
## Build
After installing the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/macos), clone this repo onto your machine. From a terminal interface, go to where this was cloned and type the following commands:

```
cd Lab1_UsingAnApi
dotnet restore
dotnet run
```
Building the app is not necessary because it has been [deployed](http://useartisanalapi.azurewebsites.net/).


---
## Walk Through
Upon arriving at the [Landing Page](http://useartisanalapi.azurewebsites.net/):

![Landing Page](/assets/landingPage.png)

Click on "View All Todo Items" in the nav bar to see all the items to do:

![All Todo Items](/assets/viewAllItems.png)

Then, click on "View All Todo Lists" in the nav bar to see all the lists:

![All Todo Lists](/assets/viewAllLists.png)

---
## Acknowledgements
- [jaatay](https://github.com/jaatay), [IndigoShock](https://github.com/IndigoShock),
Mario and I trudged through this together.

- Many thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this awesome README layout.