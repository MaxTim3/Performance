using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BucketList.Models
{
    [Table("Checkpoints")]
    public class Checkpoint
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public bool IsCompleted { get; set; }

        [ForeignKey(typeof(Goal))]
        public int GoalId { get; set; }

        /*[ManyToOne]
        public Goal Goal { get; set;}

        [OneToMany]
        public List<RepeatAction> RepeatActions { get; set; }*/
    }
}
