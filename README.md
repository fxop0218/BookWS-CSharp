# To Migrate model to database in nuget Comand line
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
