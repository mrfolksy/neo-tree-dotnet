// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using Microsoft.Build.Construction;

var solutionFile = SolutionFile.Parse(
    "/Users/chris/.config/nvim/dev/plugins/mrfolksy/neo-tree-dotnet/dotnet/example/NeoTreeDotNetExample.sln"
);

foreach (var p in solutionFile.ProjectsInOrder)
{
    Console.WriteLine($"{p.ProjectName}, {p.ProjectType}, {p.ParentProjectGuid}");
}

var jsonString = JsonSerializer.Serialize(solutionFile.ProjectsInOrder);

Console.WriteLine(jsonString);
