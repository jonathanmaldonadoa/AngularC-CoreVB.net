using Solution.Api.Application.Contracts.Services;
using Solution.Api.Business.Models;
using Solution.Api.DataAccess.Contracts.Repositories;
using Solution.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Api.Application.Services
{
    public class EmpresaService: IEmpresaService
    {
        private readonly IEMPRESARepository _IEMPRESARepository;
        public EmpresaService(IEMPRESARepository IEMPRESARepository)
        {
            _IEMPRESARepository = IEMPRESARepository;
        }


        public async Task<EmpresaModel> Add(EmpresaModel empresaModel)
        {
            var entity = await  _IEMPRESARepository.Add(EmpresaMapper.Map(empresaModel));
            return EmpresaMapper.Map(entity);
        }

        public async Task<EmpresaModel> Get(int id)
        {
            var entity = await _IEMPRESARepository.Get(id);
            return EmpresaMapper.Map(entity);
        }

        public async Task<bool> Delte(int id)
        {
            try
            {
                await _IEMPRESARepository.Delete(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<EmpresaModel>> GetAll()
        {
            var entitys = await _IEMPRESARepository.GetAll();
            var aux=  entitys.Select(EmpresaMapper.Map);
            return aux;
        }

    }
}
