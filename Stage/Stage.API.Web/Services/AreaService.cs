using AutoMapper;
using FluentResults;
using Stage.API.DAL;
using Stage.API.DAL.Models;
using Stage.API.Web.Data.Area;
using System;

namespace Stage.API.Web.Services
{
    public class AreaServices
    {   
        private Context _context;
        private IMapper _mapper;

        public AreaServices(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadAreaDto AdicionarArea(CreateAreaDto areaDto)
        {
            Area area = _mapper.Map<Area>(areaDto);
            _context.Areas.Add(area);
            _context.SaveChanges();
            return _mapper.Map<ReadAreaDto>(area);
        }

        public ReadAreaDto RecuperaAreaPorId(int id)
        {
            Area area = _context.Areas.FirstOrDefault(area => area.Id == id);
            if (area != null)
            {
                return _mapper.Map<ReadAreaDto>(area);
            }
            return null;
        }

        public Result AtualizaArea(int id, UpdateAreaDto areaDto)
        {
            Area area = _context.Areas.FirstOrDefault(area => area.Id == id);
            if (area != null)
                return Result.Fail("Area não encontrado");
            _mapper.Map(areaDto, area);
            _context.SaveChanges();
            return Result.Ok();
        }


        public Result RemoverAreaPorId(int id)
        {
            Area area = _context.Areas.FirstOrDefault(area => area.Id == id);
            if (area == null)
                return Result.Fail("Area não encontrado");
            _context.Remove(area);
            _context.SaveChanges();
            return Result.Ok();
        }


    }
}
