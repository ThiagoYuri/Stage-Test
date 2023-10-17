using AutoMapper;
using Stage.API.DAL.Models;
using Stage.API.Web.Data.Empresa;

namespace Stage.API.Web.Profiles
{
    public class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            CreateMap<CreateEmpresaDto, Empresa>();
            CreateMap<Empresa, ReadEmpresaDto>();
            CreateMap<UpdateEmpresaDto, Empresa>();

        }
    }
}
