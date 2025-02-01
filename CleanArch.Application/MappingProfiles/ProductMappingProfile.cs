using AutoMapper;
using CleanArch.Application.Features.Product.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.MappingProfiles;

public class ProductMappingProfile : Profile
{
	public ProductMappingProfile()
	{
		CreateMap<CreateProductCommand, Entities.Product>();

		CreateMap<Product, ProductDto>();

		CreateMap<UpdateProductCommand, Product>()
			.ForMember(dest => dest.Photo, opt =>
			{
				opt.Condition(src => src.Photo is not null);
				opt.MapFrom(src => src.Photo);
			});
	}
}
