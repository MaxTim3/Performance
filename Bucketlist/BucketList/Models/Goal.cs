using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BucketList.Models
{
    [Table("Goals")]
    public class Goal
    {
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public bool IsCompleted { get; set; }

        [ForeignKey(typeof(Category))]
        public int CategoryId { get; set; }

        /*[ManyToOne]
        public Category Category { get; set; }

        [OneToMany]
        public List<Checkpoint> Checkpoints { get; set; }*/
    }
}
