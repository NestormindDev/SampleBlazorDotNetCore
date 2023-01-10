using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.AggregatesModel
{
    public abstract class Entity
    {
        private int _Id;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
    }
}
