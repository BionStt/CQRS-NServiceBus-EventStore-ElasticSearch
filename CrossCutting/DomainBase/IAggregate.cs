﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.DomainBase
{
    public interface IAggregate
    {
        int Version { get; }
        Guid Id { get; }

        void ApplyEvent(IDomainEvent @event);

        IEnumerable<IDomainEvent> UncommitedEvents();
        void ClearUncommitedEvents();
    }
}
