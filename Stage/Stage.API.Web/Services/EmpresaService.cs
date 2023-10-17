using AutoMapper;
using FluentResults;
using Stage.API.DAL;
using Stage.API.DAL.Models;
using Stage.API.Web.Data.Empresa;
using System;

namespace Stage.API.Web.Services
{
    public class EmpresaServices
    {   
        private Context _context;
        private IMapper _mapper;

        public EmpresaServices(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadEmpresaDto AdicionarEmpresa(CreateEmpresaDto empresaDto)
        {
            Empresa empresa = _mapper.Map<Empresa>(empresaDto);
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
            return _mapper.Map<ReadEmpresaDto>(empresa);
        }

        public ReadEmpresaDto RecuperaEmpresaPorId(int id)
        {
            Empresa empresa = _context.Empresas.FirstOrDefault(empresa => empresa.Id == id);
            if (empresa != null)
            {
                return _mapper.Map<ReadEmpresaDto>(empresa);
            }
            return null;
        }

        public Result AtualizaEmpresa(int id, UpdateEmpresaDto empresaDto)
        {
            Empresa empresa = _context.Empresas.FirstOrDefault(empresa => empresa.Id == id);
            if (empresa != null)
                return Result.Fail("Empresa não encontrado");
            _mapper.Map(empresaDto, empresa);
            _context.SaveChanges();
            return Result.Ok();
        }


        public Result RemoverEmpresaPorId(int id)
        {
            Empresa empresa = _context.Empresas.FirstOrDefault(empresa => empresa.Id == id);
            if (empresa == null)
                return Result.Fail("Empresa não encontrado");
            _context.Remove(empresa);
            _context.SaveChanges();
            return Result.Ok();
        }


    }
}
