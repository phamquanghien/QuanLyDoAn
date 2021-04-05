using EduSoft.core.Domain.IRepository;
using EduSoft.core.Domain.IServices;
using EduSoft.core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Edusoft.core.Infrastructure.Services
{
   public class KhoaService : IkhoaService
    {
        private readonly IKhoaRepository _IkhoaRepository;
        public KhoaService(IKhoaRepository khoaRepository)
        {
            _IkhoaRepository = khoaRepository;

        }
        public async Task<List<KhoaViewModel>> SelecAllAsync()
        {
            return await _IkhoaRepository.SelectAllAsync();
        }
    }
}
