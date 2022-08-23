using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_80_483
{
    public class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }
}
