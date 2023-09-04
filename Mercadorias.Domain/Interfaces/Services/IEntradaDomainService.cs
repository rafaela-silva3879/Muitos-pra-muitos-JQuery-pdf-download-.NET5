﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercadorias.Domain.Entities;

namespace Mercadorias.Domain.Interfaces.Services
{
    public interface IEntradaDomainService : IBaseDomainService<Entrada>
    {
        List<Entrada> GetByDataEntrada(DateTime dataMin, DateTime dataMax);
    }
}
