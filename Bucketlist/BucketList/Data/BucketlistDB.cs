using BucketList.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BucketList.Data
{
    public class BucketlistDB
    {
        readonly SQLiteAsyncConnection db;

        public BucketlistDB(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);
            db.CreateTableAsync<Category>().Wait();
            db.CreateTableAsync<Goal>().Wait();
            db.CreateTableAsync<Checkpoint>().Wait();
            db.CreateTableAsync<RepeatAction>().Wait();
        }

        //Category
        public Task<List<Category>> GetCategoriesAsync()
        {
            return db.Table<Category>().ToListAsync();
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            return db.GetAsync<Category>(id);
        }

        public Task<int> SaveCategoryAsync(Category category)
        {
            if (category.Id != 0)
            {
                return db.UpdateAsync(category);
            }
            else
            {
                return db.InsertAsync(category);
            }
        }

        public Task<int> DeleteCategoryAsync(Category category)
        {
            return db.DeleteAsync(category);
        }


        //Goal
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


        //Checkpoint
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

        //RepeatAction
        public Task<List<RepeatAction>> GetRepeatActionsAsync()
        {
            return db.Table<RepeatAction>().ToListAsync();
        }

        public Task<RepeatAction> GetRepeatActionAsync(int id)
        {
            return db.GetAsync<RepeatAction>(id);
        }

        public Task<int> SaveRepeatActionAsync(RepeatAction repeatAction)
        {
            if (repeatAction.Id != 0)
            {
                return db.UpdateAsync(repeatAction);
            }
            else
            {
                return db.InsertAsync(repeatAction);
            }
        }

        public Task<int> DeleteRepeatActionAsync(RepeatAction repeatAction)
        {
            return db.DeleteAsync(repeatAction);
        }
    }
}
