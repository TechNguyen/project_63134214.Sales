﻿using Sale.Domain.Entities;
using Sale.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Repository.OrdersRepository
{
	public interface IOrdersRepository : IRepository<Orders>
	{
	}
}
