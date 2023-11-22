using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
    public class Payment
    {
            public int Id { set; get; }
            public int UserId { set; get; }
            public decimal Amount { set; get; }

            public User User { set; get; }

        }
}
