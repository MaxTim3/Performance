using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using BucketList.Models;
using System.Threading.Tasks;

namespace BucketList.Data
{
    public class CheckpointsDB
    {
        readonly SQLiteAsyncConnection db;

        public CheckpointsDB(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);
            db.CreateTableAsync<Checkpoint>().Wait();
        }

        public Task<List<Checkpoint>> GetCheckpointsAsync()
        {
            return db.Table<Checkpoint>().ToListAsync();
        }

        public Task<Checkpoint> GetCheckpointAsync(int id)
        {
            return db.GetAsync<Checkpoint>(id);
        }

        public Task<int> SaveCheckpointAsync(Checkpoint checkpoint)
        {
            if (checkpoint.Id != 0)
            {
                return db.UpdateAsync(checkpoint);
            }
            else
            {
                return db.InsertAsync(checkpoint);
            }
        }

        public Task<int> DeleteCheckpointAsync(Checkpoint checkpoint)
        {
            return db.DeleteAsync(checkpoint);
        }
    }
}
