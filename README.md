# Migration
```
 dotnet ef --startup-project ../../Presentation/BookStore.Api/ migrations add Mg_1
 dotnet ef --startup-project ../../Presentation/BookStore.Api/ database update 
```
# Remove Unused Using
```
OmniSharp: Fix all occurrences of a code issue within solution

@command:o.fixAll.solution
```

#migration with environment
```
dotnet ef --startup-project ../../Presentation/BookStore.Api/ database update  -- --environment Testing
dotnet ef --startup-project ../../Presentation/BookStore.Api/ database update  -- --environment Productions
```