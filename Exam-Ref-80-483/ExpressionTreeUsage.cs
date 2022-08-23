using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_80_483
{
    public class ExpressionTreeUsage
    {
        public void Run()
        {
            BlockExpression blockExpr = Expression.Block(
            Expression.Call(
                null,
                typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
                Expression.Constant("Hello ")
                ),
            Expression.Call(
                null,
                typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
                Expression.Constant("World")
                )
            );

            Expression.Lambda<Action>(blockExpr).Compile()();
        }        
    }
}
