using System;
using ERP.Product.Domain.Commands.Reponses;
using ERP.Product.Domain.Commands.Requests;

namespace ERP.Product.Domain.Interfaces.Commands.Handlers
{
	public interface ICreateMetadataHandler
	{
		CreateMetadataResponse Handle(CreateMetadataRequest command);
	}
}

