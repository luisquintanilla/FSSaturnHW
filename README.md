# FSSaturnHW

Sample Hello World Saturn F# Framework Application

Saturn Website: https://saturnframework.org/
Saturn Docs: https://saturnframework.org/docs/

## Create App

1. Create a new directory for your application.
2. Navigate to your newly created directory and use the .NET CLI to create an F# Console application.

```dotnetcli
dotnet new console -lang F#
```

3. Use the .NET CLI to add the `Saturn` package.

```dotnetcli
dotnet add package Saturn
```

4. Replace the contents of your *Program.fs* file with those in this projects *Program.fs* file.

## Build 

```dotnetcli
dotnet build
```

## Run

```dotnetcli
dotnet run
```

### Sample Responses

GET `http://localhost:7078/api/values`

```json
[
    1,
    2,
    3
]
```

GET `http://localhost:7078/api/values/1`

```json
{
    "case": "Some",
    "fields": [
        1
    ]
}
```
