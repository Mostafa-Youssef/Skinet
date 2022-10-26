using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public enum Orderstatus
    {
        [EnumMember(Value ="Pending")]
        Pending,

        [EnumMember(Value ="PaymentRecevied")]
        PaymentRecevied,
        
        [EnumMember(Value ="PaymentFailed")]
        PaymentFailed

    }
}