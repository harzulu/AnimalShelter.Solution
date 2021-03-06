<br>
<p align="center">
  <b style="margin-left: 1rem; margin-right: 1rem; font-size: 5em">Animal Shelter API</b>
</p>

<p align="center">
    <br>
    <a href="https://github.com/Harzulu">
        <img style="border-radius: 100%; height: 50px; width: auto" src="https://avatars3.githubusercontent.com/u/55816973?s=460&u=46b7375105009121ce5ce53643553fef0ba2be14&v=4">
    </a>
</p>

<p align="center">
  <small>Last Updated: January 22th, 2021</small>
</p>

# ℹ️ Description

This is the code to run an Animal Shelter API that can give, change, delete, etc. all data of the animal shelter!

# 🧑‍💻 Contributers

| Name | GitHub Profile |
|------|----------------|
|[Ben McFarland](https://www.linkedin.com/in/benjamin-mcf/)|[Harzulu](https://github.com/harzulu)|

# 📞 API Endpoints and Examples

<details>
  <summary>Click to view</summary>

## 🐕 Dogs:

**GET http://localhost:5001/api/dogs**

Output:
```
[
    {
        "dogId": 1,
        "name": "Uma",
        "breed": "Pit Bull"
    },
    {
        "dogId": 2,
        "name": "Abner",
        "breed": "Australian Cattledog"
    },
    {
        "dogId": 3,
        "name": "Jackson",
        "breed": "Lab Mix"
    }
]
```

**GET http://localhost:5001/api/dogs/2**

Output:
```
[
    {
        "dogId": 2,
        "name": "Abner",
        "breed": "Australian Cattledog"
    }
]
```

**POST http://localhost:5001/api/dogs**

Body:
```
{
  "dogId": 11,
  "name": "Teddy",
  "breed": "Greyhound"
}
```

**PUT http://localhost:5001/api/dogs/2**

Body:
```
{
  "dogId": 2,
  "name": "Roger",
  "breed": "Bulldog"
}
```

**DELETE http://localhost:5001/api/dogs/2**

Output:
```

```

## 🐈 Cats:

**GET http://localhost:5001/api/cats**

Output:
```
[
  {
        "catId": 1,
        "name": "Baby Girl",
        "breed": "Short Hair"
    },
    {
        "catId": 2,
        "name": "Inky",
        "breed": "Short Hair"
    },
    {
        "catId": 3,
        "name": "Marley",
        "breed": "Siamese"
    }
]
```

**GET http://localhost:5001/api/cats/3**

```
[
  {
    "catId": 3,
    "name": "Marley",
    "breed": "Siamese"
  }
]
```

**POST http://localhost:5001/api/cats**

```
{
  "catId": 7,
  "name": "Lilly"
  "breed": "Long Hair"
}
```

**PUT http://localhost:5001/api/cats/3**

```
{
  "catId": 3,
  "name": "Gus"
  "breed": "Persian"
}
```

**DELETE http://localhost:5001/api/cats/3**

Output:
```

```
</details>

# ⚙️ Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

* <a href="https://code.visualstudio.com/">Microsoft Visual Studio Code</a>
* <a href="https://github.com/">Git/GitHub</a>
* <a href="https://docs.microsoft.com/en-us/dotnet/csharp/">C#</a>
* <a href="https://dotnet.microsoft.com/download">.NET Core</a>
* <a href="https://repl.it/languages/csharp">REPL</a>
* <a href="https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started">ASP.NET MVC</a>
* <a href="https://developer.mozilla.org/en-US/docs/Learn/CSS">CSS</a>
* <a href="https://getbootstrap.com/">Bootstrap</a>
* <a href="https://docs.microsoft.com/en-us/ef/core/">EF Core</a>
* <a href="https://www.mysql.com/">MySQL/My SQL Workbench</a>
* <a href="postman.com">Postman</a>
* <a href="https://swagger.io/tools/swagger-ui/">Swagger/Swagbuckle</a>

</details>

# 💾 Installation Requirements

## For Both  Mac & Windows systems

* Once you have Git installed on your computer, go to <a href="https://github.com/harzulu/AnimalShelter.Solution">this GitHub repository</a>, click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:
<br> `git clone https://github.com/harzulu/AnimalShelter.Solution`.

## 📁 Installing C#, .NET, dotnet script, & MySQL

### **This program requires C# and the .NET Framework to be installed on your machine:**

## For Mac 
 * Download <a href="https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer">this</a> .NET Core SDK (Software Development Kit). Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`, which should return something like: `2.2.105`. 

## For Windows (10+)

* Download <a href="https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer">this</a> 64-bit .NET Core SDK (Software Development Kit). Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `2.2.105`.

## For Mac & Windows Operating Systems

* Install dotnet script with the following terminal command:
<br> `dotnet tool install -g dotnet-script`.

# 🖥️ Opening the Project on your Local System

* Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice (<a href="https://code.visualstudio.com/">Visual Code Studio</a> was used and is recommended by the application builder)

### AppSettings.json File

You will need to create an `appsettings.json` file in the `AnimalShelter` folder. <br>
Once you have the file made, put in this code: <br>
```
{
    "Logging": {
      "LogLevel": {
        "Default": "Warning"
      }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=root;pwd=[PASSWORD];"
    }
}
```
**Make sure to have a MySQL server up and running on your machine on port 3306** <br>
**Replace `PASSWORD` with the password to your server created for this project**
**Replace `DATABASE_NAME` with the name of your database**

### MySQL Database Setup

* First, using your terminal or command line, navgate to the AnimalShelter folder in AnimalShelter.Solution: `/AnimalShelter.Solution/AnimalShelter`.
* Next, run the command: `dotnet ef database update`.
* You should have your database created for this project.

### Calling the API
* Finally, run the command `dotnet build` to get bin/ and obj/ folders downloaded, then `dotnet run` to run the application. The program should be connected to a localhost port, most likely 5000. Your terminal or command line should specify which port it is on.
* Once you have your project running, this is the base API path: `http://localhost:[PORT_NUMBER]/api/[ANIMAL]`.
* View [here](#📞-api-endpoints-and-examples) to see what end points you can call.

# 😎 Using Swagger UI

### The Swagger UI is already incorporated. To view the UI:

* Run the command `dotnet run` to make your application live.
* Find the port number your console gives you that the site is live on. This will usually be port 5000 or 5001.
* In your web browser, go to this URL: `http://localhost:[PORT_NUMBER]/index.html`.

# ☎️ Support / Contact Details

* Ben McFarland benrmcfarland@gmail.com

# 🪲 Bugs / Issues

No known bugs or issues

# ©️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 *_Ben McFarland_*