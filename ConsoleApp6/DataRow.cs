﻿namespace ConsoleApp6;

public class DataRow
{
    public Dictionary<string, object> Values { get; set; }

    public DataRow()
    {
        Values = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
    }
}
