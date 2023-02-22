using System;
using System.Runtime.Serialization;

namespace ERP.Product.Domain.Enums
{
	public enum TypeEnum
	{
        [EnumMember(Value = "URL")]
        URL = 1,
        [EnumMember(Value = "Text")]
        Text = 2,
        [EnumMember(Value = "Number")]
        Number = 3,
        [EnumMember(Value = "Array")]
        Array = 4,
        [EnumMember(Value = "Property")]
        Property = 5
    }
}

