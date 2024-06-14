using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BucketList.Models
{
    public class Checkpoint
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Date {  get; set; }
        public bool IsCompleted { get; set; }
    }
}
