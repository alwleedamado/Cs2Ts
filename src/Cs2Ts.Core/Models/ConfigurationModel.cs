using System;
using System.Collections.Generic;
using System.Text;

namespace Cs2Ts.Core.Models;

public class ConfigurationModel
{
    public  required string Project { get; set; }
    public required string OutputDirectory { get; set; }
    public string ModelsNamespace { get; set; } = string.Empty;
    public NamingStrategy NamingStrategy { get; set; } = NamingStrategy.Preserve;
    public NullabilityStrategy NullabilityStrategy { get; set; } = NullabilityStrategy.TypeOrNull;
}

public enum NamingStrategy
{
    Preserve,
    CamelCase
}

public enum NullabilityStrategy
{
    OptionalProperty,
    TypeOrNull
}
