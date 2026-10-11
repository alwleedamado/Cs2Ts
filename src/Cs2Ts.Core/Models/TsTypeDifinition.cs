using System;
using System.Collections.Generic;
using System.Text;

namespace Cs2Ts.Core.Models;

public class TsTypeDifinition
{
    public required string Name { get; set; }
    public TsType TsType { get; set; }
    public List<TsMember> Members { get; set; } = [];
    public bool IsGeneric { get; set; }
    public int GenericParamtersCount {  get; set; }
}

public class TsMember
{
    public required string Name { get; set; }
    public TsType TsType { get; set; }
    public bool IsNullable { get; set; }
    public bool IsGeneric { get; set; }
}

public enum TsType
{
    Number,
    String,
    Boolean,
    Date,
    Record,
    Class,
    Interface
}