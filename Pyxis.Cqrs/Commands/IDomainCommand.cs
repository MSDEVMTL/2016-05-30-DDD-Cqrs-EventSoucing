﻿using System;
using Pyxis.Cqrs.Messages;

namespace Pyxis.Cqrs.Commands
{
    public interface IDomainCommand : IDomainMessage
    {
    }
}