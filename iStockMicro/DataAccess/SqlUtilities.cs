using iStockMicro.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.DataAccess
{
    public class SqlUtilities
    {
        private readonly SQLiteAsyncConnection _db;

        public SqlUtilities()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "istockmicro.db");
            _db = new SQLiteAsyncConnection(dbPath);
            
            CreateTables();
        }

        private async void CreateTables()
        {
           await _db.CreateTableAsync<UsrCode>();
           await _db.CreateTableAsync<Category>();
           await _db.CreateTableAsync<SaleHead>();
            await _db.CreateTableAsync<SaleDet>();
        }


        public async Task<List<T>> GetListAsync<T>() where T  : new ()
        {
            return await _db.Table<T>().ToListAsync();
        }
      
        public async Task<int>  InsertAll<T>(IEnumerable<T> entity)
        {
            int count = await _db.InsertAllAsync(entity);
            return count;
        }
        public async Task<int> Insert<T>(T entity)
        {
            int count = await _db.InsertAsync(entity);
            return count;
        }

        public async Task<int> Update<T>(T entity)
        {
            int count = await _db.UpdateAsync(entity);
            return count;
        }

    }
}
