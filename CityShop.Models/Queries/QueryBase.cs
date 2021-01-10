using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityShop.Domain.Queries
{
    public abstract class QueryBase<TResult> : IRequest<TResult> where TResult:class
    {
    }
}
