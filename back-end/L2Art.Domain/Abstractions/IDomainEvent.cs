﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Art.Domain.Abstractions
{
    public interface IDomainEvent : INotification
    {
    }
}
