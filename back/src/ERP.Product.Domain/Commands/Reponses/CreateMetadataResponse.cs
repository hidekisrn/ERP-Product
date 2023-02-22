using System;
using ERP.Product.Domain.Entities;

namespace ERP.Product.Domain.Commands.Reponses
{
	public class CreateMetadataResponse
	{
		public int Id { get; set; }
		public Property[] Properties { get; set; } = Array.Empty<Property>();
    }
}

