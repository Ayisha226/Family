using System;
using System.Collections.Generic;
using System.Text;
using DAL.Base;
using DAL.Entity;

namespace DAL.Models
{
    public class Card:BaseEntity,IEntity
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public string MaritalStatus { get; set; }

    }
}
