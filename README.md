# _Beast Rescue of the Pacific Northwest_

#### By _Melissa Scmi_
<br/>

#### _Beast Rescue Rescues Beasts_
<br/>

Descrip Goes Here

<hr>
<br/>

## Technologies Used
* _C#_
* _NuGet_
* _.NET 5_
* _MySql_
* _ASP.NET Core_
* _Entity Framework_
* _Swagger_


## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash
- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)

### Setup/Installation

* Clone [this repository](https://github.com/tigertiger/BeastRescue.Solution) to an empty folder or to your desktop, or download and open the Zip on your local machine. Instructions for cloning can be found [here](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository).
* Open the ```BeastRescue.Solution``` folder in your preferred text editor
* Set up your SQL database using MySQL:
   - Create a new `appsettings.json` file in ```BeastRescue.Solution/BeastRescue```
   - Copy the following code into that file, replacing `YOUR_PASSWORD` with your MySQL password:
   ```
        "Logging": {
         "LogLevel": {
           "Default": "Warning",
           "System": "Information",
           "Microsoft": "Information"
         }
      },
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=beast_rescue;uid=root;pwd=YOUR_PASSWORD;"
         }
     }
   ```
* This repo includes database Migrations. To make use of those, simply run ```dotnet ef database update``` in your ```BeastRescue.Solution/BeastRescue``` directory

* Restore and build the project:
  - Navigate to the ```BeastRescue.Solution/BeastRescue``` folder in the command line or terminal  
    -- Run ```dotnet restore``` to restore the project dependencies  
    -- Run ```dotnet build``` to build and compile the project

* Use the API:
  - Navigate to the ```BeastRescue.Solution/BeastRescue``` folder in the terminal
  - Run ```dotnet run``` 
  - If you would like to be able to continue viewing results while making changes to content, instead run ```dotnet watch run```

## Documentation and Routes

### Swagger

_This project includes [Swagger](https://swagger.io/). Per [Epicodus](https://www.epicodus.com/), "Swagger is an open-source standardized and language-agnostic interface for designing and documenting REST APIs. It can be used to design APIs before they’re built or to document APIs after the code has already been implemented." [see citation](https://www.learnhowtoprogram.com/c-and-net/building-an-api/further-exploration-with-apis)_
_To access Swagger Documentation for API calls for GET, PATCH, and POST:_
 - Run the application from ```BeastRescue.Solution/BeastRescue``` in your command line
 - Once the application is running, go to `http://localhost:5000`
  -- You can also follow this link while the program is running [Swagger](http://localhost:5000).

### Manual Routes

- GET `/api/beasts`
    - Returns all beasts in database

- GET `/api/beasts/{id}`
    - Returns a single beast with the specified ID

- POST `/api/beasts`
    - Creates a new beast in the database

- PUT `/api/beasts/{id}`
    - Edits the existing beast with the specified id

- DELETE `/api/beasts/{id}`
    - Deletes the existing beast with the specified id


## Known Issues
* _None, yet_

## License

_[GPL](https://opensource.org/licenses/gpl-license)_
_Copyright (c) 2021, Melissa Schatz-Miller_

## Contact Information  

Melissa Schatz-Miller <melissa.scmi@gmail.com>  
_Please feel free to reach out to me with suggested changes/improvements, or if you have any questions._