using System;
using System.Collections.Generic;
using System.Text;
using DAL.Base;
using DAL.Entity;

namespace DAL.Models
{
    public class Image:BaseEntity,IEntity
    {
        public string Url { get; set; }
    }
}
