﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using DataAccess.Core.Linq.Enums;

namespace DataAccess.Core.Linq.Common.Expressions
{
    /// <summary>
    /// 
    /// </summary>
    public class RowNumberExpression : DbExpression
    {
        /// <summary>
        /// Gets the order by.
        /// </summary>
        public ReadOnlyCollection<OrderExpression> OrderBy { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RowNumberExpression"/> class.
        /// </summary>
        /// <param name="orderBy">The order by.</param>
        public RowNumberExpression(IEnumerable<OrderExpression> orderBy)
            : base(DbExpressionType.RowCount, typeof(int))
        {
            this.OrderBy = orderBy.ToReadOnly();
        }
    }
}
