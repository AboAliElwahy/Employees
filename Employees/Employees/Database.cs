using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database (string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>();
        }
        public Task<List<Person>> GetPersonsAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }
        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }
        public Task<int> UpdatePersonAsync(Person person)
        {
            return _database.UpdateAsync(person);
        }
        public Task<int> DeletePersonAsync(Person person)
        {
            return _database.DeleteAsync(person);
        }
    }
}
