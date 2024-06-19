using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BucketList.Models
{
    public class RepeatAction
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
