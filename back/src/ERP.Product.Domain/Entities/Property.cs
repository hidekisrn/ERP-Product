using System;
using ERP.Product.Domain.Enums;

namespace ERP.Product.Domain.Entities
{
	public class Property
	{
		public string Key { get; set; } = string.Empty;
		public dynamic? Value { get; set; }
		public TypeEnum Type { get; set; }
    }
}

