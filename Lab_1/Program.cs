Console.WriteLine("Минимальные и максимальные значения для типов данных CTS:");
Console.WriteLine("========================================================");
        
        // Целочисленные типы со знаком
Console.WriteLine($"sbyte:  Min = {sbyte.MinValue}, Max = {sbyte.MaxValue}");
Console.WriteLine($"short:  Min = {short.MinValue}, Max = {short.MaxValue}");
Console.WriteLine($"int:    Min = {int.MinValue}, Max = {int.MaxValue}");
Console.WriteLine($"long:   Min = {long.MinValue}, Max = {long.MaxValue}");
Console.WriteLine();
        
        // Целочисленные типы без знака
Console.WriteLine($"byte:   Min = {byte.MinValue}, Max = {byte.MaxValue}");
Console.WriteLine($"ushort: Min = {ushort.MinValue}, Max = {ushort.MaxValue}");
Console.WriteLine($"uint:   Min = {uint.MinValue}, Max = {uint.MaxValue}");
Console.WriteLine($"ulong:  Min = {ulong.MinValue}, Max = {ulong.MaxValue}");
Console.WriteLine();
        
        // Вещественные типы
Console.WriteLine($"float:  Min = {float.MinValue}, Max = {float.MaxValue}");
Console.WriteLine($"double: Min = {double.MinValue}, Max = {double.MaxValue}");
Console.WriteLine($"decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");
Console.WriteLine();
        
        // Символьный тип (упрощенный вывод)
Console.WriteLine($"char:   Min = {(int)char.MinValue}, Max = {(int)char.MaxValue} (коды Unicode)");       
Console.WriteLine();
        
        // Логический тип
Console.WriteLine($"bool:   Min = {false}, Max = {true}");
Console.WriteLine();
        