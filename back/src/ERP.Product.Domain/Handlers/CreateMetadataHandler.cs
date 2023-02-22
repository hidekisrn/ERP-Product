using System;
using ERP.Product.Domain.Commands.Reponses;
using ERP.Product.Domain.Commands.Requests;
using ERP.Product.Domain.Entities;
using ERP.Product.Domain.Interfaces.Commands.Handlers;

namespace ERP.Product.Domain.Handlers
{
	public class CreateMetadataHandler : ICreateMetadataHandler
	{
		public CreateMetadataHandler()
		{
		}

		public CreateMetadataResponse Handle(CreateMetadataRequest command)
		{
			var metadata = new Metadata(command.Properties);

			return new CreateMetadataResponse
			{
				Id = metadata.Id,
				Properties = metadata.Properties
			};
		}
	}
}

