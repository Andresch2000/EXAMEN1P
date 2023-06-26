using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EXAMEN1P.Controllers
{
    public class DataBase
    {
        readonly SQLiteAsyncConnection _connection;

        public DataBase() { }
        public DataBase(string dbpath)
        {
            _connection = new SQLiteAsyncConnection(dbpath);
            _connection.CreateTableAsync<Models.Contactos>().Wait();
        }

        public Task<int> AddContacto(Models.Contactos cts)
        {
            if (cts.id == 0)
            {
                return _connection.InsertAsync(cts);
            }
            else
            {
                return _connection.UpdateAsync(cts);
            }
        }

        public Task<List<Models.Contactos>> ObtenerListaContacto()
        {
            return _connection.Table<Models.Contactos>().ToListAsync();

        }
        public Task<Models.Contactos> ObtenerContacto(int pid)
        {
            return _connection.Table<Models.Contactos>().Where(i => i.id == pid).FirstOrDefaultAsync();

        }

        public Task<int> DeleteContacto(Models.Contactos cts)
        {
            return _connection.DeleteAsync(cts);
        }

    }
}
