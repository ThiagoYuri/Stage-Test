using AutoMapper;
using Stage.API.DAL.Models;
using Stage.API.Web.Data;
using Stage.API.Web.Data.Area;
using Stage.API.Web.Data.Processo;

namespace Stage.API.Web.Profiles
{
    public class ProcessoProfile : Profile
    {
        public ProcessoProfile()
        {
            CreateMap<CreateProcessoDto, Processo>();
            CreateMap<Processo, ReadProcessoDto>();
            CreateMap<UpdateProcessoDto, Processo>();

        }
    }
}
