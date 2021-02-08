using AutoMapper;
using FastFood.Models;
using FastFood.Web.ViewModels.Categories;
using FastFood.Web.ViewModels.Employees;
using FastFood.Web.ViewModels.Items;
using FastFood.Web.ViewModels.Orders;
using FastFood.Web.ViewModels.Positions;

namespace FastFood.Web.MappingConfiguration
{
    public class FastFoodProfile : Profile
    {
        public FastFoodProfile()
        {
            this.CreateMap<CreatePositionInputModel, Position>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.PositionName)).ReverseMap();

            this.CreateMap<CreateCategoryInputModel, Category>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.CategoryName)).ReverseMap();

            this.CreateMap<RegisterEmployeeInputModel, Employee>().ReverseMap();

            this.CreateMap<CreateItemInputModel, Item>().ReverseMap();

            this.CreateMap<CreateOrderInputModel, Order>().ReverseMap();
        }
    }
}
