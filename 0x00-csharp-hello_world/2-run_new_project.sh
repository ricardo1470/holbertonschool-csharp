#!/usr/bin/env bash
dotnet new console -o ./2-new_project/
dotnet build ./2-new_project/
dotnet run --project ./2-new_project/


dotnet new console -o ./InventoryLibrary/ && dotnet build ./InventoryLibrary/
dotnet run --project ./InventoryLibrary/

dotnet new sln

/// <summary>Base class</summary>
class BaseClass
{
    /// <summary>Base class</summary>
    public string id;
    /// <summary>Base class</summary>
    public DateTime date_created;
        /// <summary>Base class</summary>
    public DateTime date_updated;

}