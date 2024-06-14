using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using BucketList.Models;
using System.Threading.Tasks;

namespace BucketList.Data
{
    public class GoalsDB
    {
        readonly SQLiteAsyncConnection db;

        public GoalsDB(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);
            db.CreateTableAsync<Goal>().Wait();
        }

        public Task<List<Goal>> GetGoalsAsync()
        {
            return db.Table<Goal>().ToListAsync();
        }

        public Task<Goal> GetGoalAsync(int id)
        {
            return db.GetAsync<Goal>(id);
        }

        public Task<int> SaveGoalAsync(Goal goal)
        {
            if (goal.Id != 0)
            {
                return db.UpdateAsync(goal);
            }
            else
            {
                return db.InsertAsync(goal);
            }
        }

        public Task<int> DeleteGoalAsync(Goal goal)
        {
            return db.DeleteAsync(goal);
        }
    }
}
