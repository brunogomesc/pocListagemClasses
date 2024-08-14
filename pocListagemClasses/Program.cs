using System.Reflection;

// Caminho do assembly que você deseja carregar (use o caminho absoluto ou relativo)
string assemblyPath = @"Classes_Be.dll";


// Carrega o assembly a partir do caminho especificado
Assembly assembly = Assembly.LoadFrom(assemblyPath);

// Obtém todas as classes (tipos) no assembly
var types = assembly.GetTypes()
                    .Where(t => t.IsClass)
                    .OrderBy(t => t.Name);

// Itera sobre cada classe
foreach (var type in types)
{
    Console.WriteLine($"Classe: {type.Name}");

    // Obtém todas as propriedades da classe
    var properties = type.GetProperties();

    // Itera sobre cada propriedade
    foreach (var property in properties)
    {
        Console.WriteLine($"\tPropriedade: {property.Name} (Tipo: {property.PropertyType.Name})");
    }

    Console.WriteLine();
}
