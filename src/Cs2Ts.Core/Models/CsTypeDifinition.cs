using System;
using System.Collections.Generic;
using System.Text;

namespace Cs2Ts.Core.Models;

public class CsTypeDifinition
{
    public required string Name { get; set; }
    public bool IsAbstract { get; set; }
    public CsTypeDifinition? Parent { get; set; }
    public List<CsMember> Members { get; set; } = [];
    public bool IsGeneric { get; set; }
    public int GenericParamtersCount { get; set; }
}

public class CsMember
{
    public required string Name { get; set; }
    public CsMemberTYpe MemberTYpe { get; set; }
    public CsType CsType { get; set; }
    public bool IsRequired { get; set; }
    public bool IsNullable { get; set; }
    public bool IsGeneric { get; set; }
} 

public enum CsType
{
    String,
    Bool,
    Class,
    Enum,
    Record,
    Int,
    Decimal,
    Float,
    Double,
    DateTime,
    DateOnly,
    TimeOnly,
    DateTimeOffset,
    Interface
}

public enum CsMemberTYpe
{
    Field,
    Property
}
