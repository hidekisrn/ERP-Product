using System;

namespace ERP.Product.Domain.Entities
{
	public class Property
	{
		public string Key { get; set; } = string.Empty;
		public dynamic? Value { get; set; }
		public int Type { get; set; }
    }
}

