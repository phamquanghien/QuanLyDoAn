using Dapper;
using EduSoft.core.Domain.IRepository;
using EduSoft.core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Edusoft.core.Infrastructure.Repository
{
    public class KhoaRepository : IKhoaRepository
    {
        private readonly string _connectionString;
        private readonly string _IKhoaRepository;
        public KhoaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<KhoaViewModel>> SelectAllAsync()  {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Closed)
                    await conn.OpenAsync();
                var Result = await conn.QueryAsync<KhoaViewModel>("spKhoa_SelectAll");
                return Result.ToList();
            }
        }
    }
}
