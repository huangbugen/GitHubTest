using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleTest
{
    internal class NewExpressionVisitor : ExpressionVisitor
    {
        public ParameterExpression Param { get; private set; }
        public NewExpressionVisitor(ParameterExpression param)
        {
            Param = param;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return this.Param;
        }
    }
}