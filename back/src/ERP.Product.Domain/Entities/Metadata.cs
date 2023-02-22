using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Product.Domain.Entities
{
	public class Metadata
	{
		public int Id { get; set; }

        [Column(TypeName = "jsonb")]
        public Property[]? Properties { get; set; }
    }
}

