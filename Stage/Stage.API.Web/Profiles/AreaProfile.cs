using AutoMapper;
using Stage.API.DAL.Models;
using Stage.API.Web.Data.Empresa;

namespace Stage.API.Web.Profiles
{
    public class AreaProfile : Profile
    {
        public AreaProfile()
        {
            CreateMap<CreateAreaDto, Area>();
            CreateMap<Area, ReadAreaDto>();
            CreateMap<UpdateAreaDto, Area>();

        }
    }
}
