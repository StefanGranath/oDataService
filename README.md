# oDataService
Simple OData example using EF + .NET 6

This code assumes that your local machine are running SQL Server and uses this for data persistance. Only basic capabilities are demonstrated here.

1) Run: dotnet ef database upgrade to initate the database from the oDataService project folder
2) Insert some data into Students table: 
```SQL
INSERT INTO Students (Name, Score)
VALUES ('Stefan Granath', 200),
       ('Hanna Andersson', 160),
       ('Fabian Bengtsson', 170)
```

Do the following to expermient with OData queries
* http://localhost:5078/api/students
```JSON
[
    {
        "id": 1,
        "name": "Stefan Granath",
        "score": 200
    },
    {
        "id": 2,
        "name": "Hanna Andersson",
        "score": 160
    },
    {
        "id": 3,
        "name": "Fabian Banan",
        "score": 170
    }
]
```
* http://localhost:5078/api/students?$select=Name
```JSON
[
    {
        "Name": "Stefan Granath"
    },
    {
        "Name": "Hanna Andersson"
    },
    {
        "Name": "Fabian Banan"
    }
]
```
* http://localhost:5078/api/students?$select=Name&$filter=score lt 180
```JSON
[
    {
        "Name": "Hanna Andersson"
    },
    {
        "Name": "Fabian Banan"
    }
]
```
* http://localhost:5078/api/students?$select=Name&$filter=score lt 180 and startswith(name, 'fab')
```JSON
[
    {
        "Name": "Fabian Banan"
    }
]
```
* http://localhost:5078/api/students?$select=Name&orderby=name asc
```JSON
[
    {
        "Name": "Fabian Banan"
    },
    {
        "Name": "Hanna Andersson"
    },
    {
        "Name": "Stefan Granath"
    }
]
```
