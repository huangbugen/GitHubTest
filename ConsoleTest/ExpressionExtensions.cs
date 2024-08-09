using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> exp1, Expression<Func<T, bool>> exp2)
        {
            if (exp1 == null || exp2 == null)
            {
                throw new Exception("null不能处理");
            }

            ParameterExpression newParameter = Expression.Parameter(typeof(T), "x");
            NewExpressionVisitor visitor = new NewExpressionVisitor(newParameter);
            Expression left = visitor.Visit(exp1.Body);
            Expression right = visitor.Visit(exp2.Body);
            BinaryExpression body = Expression.And(left, right);
            return Expression.Lambda<Func<T, bool>>(body, newParameter);
        }
    }
}