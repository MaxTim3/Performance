using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BucketList.Models
{
    public class Goal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Date {  get; set; }
        public bool IsCompleted { get; set; }

        [Indexed]
        public int CheckpointId {  get; set; }
    }
}
