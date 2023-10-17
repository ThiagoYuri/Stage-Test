using AutoMapper;
using FluentResults;
using Stage.API.DAL;
using Stage.API.DAL.Models;
using Stage.API.Web.Data.Processo;
using System;

namespace Stage.API.Web.Services
{
    public class ProcessoServices
    {   
        private Context _context;
        private IMapper _mapper;

        public ProcessoServices(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadProcessoDto AdicionarProcesso(CreateProcessoDto processoDto)
        {
            Processo processo = _mapper.Map<Processo>(processoDto);
            _context.Processos.Add(processo);
            _context.SaveChanges();
            return _mapper.Map<ReadProcessoDto>(processo);
        }

        public ReadProcessoDto RecuperaProcessoPorId(int id)
        {
            Processo processo = _context.Processos.FirstOrDefault(processo => processo.Id == id);
            if (processo != null)
            {
                return _mapper.Map<ReadProcessoDto>(processo);
            }
            return null;
        }

        public Result AtualizaProcesso(int id, UpdateProcessoDto processoDto)
        {
            Processo processo = _context.Processos.FirstOrDefault(processo => processo.Id == id);
            if (processo != null)
                return Result.Fail("Processo não encontrado");
            _mapper.Map(processoDto, processo);
            _context.SaveChanges();
            return Result.Ok();
        }


        public Result RemoverProcessoPorId(int id)
        {
            Processo processo = _context.Processos.FirstOrDefault(processo => processo.Id == id);
            if (processo == null)
                return Result.Fail("Processo não encontrado");
            _context.Remove(processo);
            _context.SaveChanges();
            return Result.Ok();
        }


    }
}
