# Book WebService with C#

The bootsrrap theme has been deleted from the project, the theem used its: 

This project consists of a book manager, which allows you to create it with C#, JS, CSS and MySQL.

Important things to keep in mind:

## To Migrate model to database in nuget Comand line
### Microsoft.EntityFrameworkCore.Tools needed
Create migration files
```
add-migration AddCategoryToDatabase
```

Update SQL database with migration file
```
update-database
```

appsettings.json connection:
```
  "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-xxxxxxx\\SQLEXPRESS;Database=xxxxx;Trusted_Connection=True;encrypt=false"
  }
 ```
