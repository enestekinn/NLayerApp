using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public abstract class BaseEntity
    {

        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }

        //nesne ilk kez yaratildiginda null olmasi gerek
        public DateTime? UpdateDate { get; set; }

    }
}
