using System;
using ERP.Product.Domain.Entities;

namespace ERP.Product.Domain.Commands.Requests
{
	public class CreateMetadataRequest
	{
		public Property[] Properties { get; set; } = Array.Empty<Property>();
	}
}

