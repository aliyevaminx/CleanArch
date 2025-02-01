using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Persistence.Repositories;

public class ProductWriteRepository : BaseWriteRepository<Core.Entities.Product>, IProductWriteRepository
{
	public ProductWriteRepository(AppDbContext context) : base(context)
	{

	}
}
