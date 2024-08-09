using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class OperationsVisitor : ExpressionVisitor
    {
        protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.NodeType == ExpressionType.Add)
            {
                Expression left = this.Visit(node.Left);
                Expression right = this.Visit(node.Right);
                return Expression.Subtract(left, right);
            }
            return base.VisitBinary(node);
        }
    }
}