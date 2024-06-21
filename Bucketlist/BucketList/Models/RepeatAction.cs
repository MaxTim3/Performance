using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BucketList.Models
{
    [Table("RepeatActions")]
    public class RepeatAction
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int Number {  get; set; }

        public bool IsComlpeted { get; set; }


        [ForeignKey(typeof(Checkpoint))]
        public int CheckpointId { get; set; }

        /*[ManyToOne]
        public Checkpoint Checkpoint { get; set; }*/
    }
}
