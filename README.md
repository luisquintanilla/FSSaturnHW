# FSSaturnHW

Sample Hello World Saturn F# Framework Application

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
