using System;
namespace ERP.Product.Domain.Entities
{
	public class PropertyType
	{
		public int Id { get; set; }
		public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
	}
}

