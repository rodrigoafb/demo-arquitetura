﻿using System;
using System.Collections.Generic;

namespace Demo.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioDeVenda : IRepositorioBase<Venda>
    {
        IList<Venda> RecuperarVendasPorData(DateTime data);
        IList<Venda> RecuperarVendas(DateTime? datainicial, DateTime? datafinal, int? cliente);
    }
}