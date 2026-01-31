using AutoMapper;
using ECommerce.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;


namespace ECommerce.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Product mappings
            CreateMap<Product, ProductDTO>();
            CreateMap<CreateProductDTO, Product>();

            // Order mappings
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderItem, OrderItemDTO>();

            // Address mapping
            CreateMap<Address, AddressDTO>();
        }
    }
}
