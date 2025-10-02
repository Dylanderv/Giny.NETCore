using System.Linq.Expressions;

namespace Giny.ORM.Expressions;

public class ExpressionsManager
{
    public delegate T ObjectActivator<T>(params object[] args);

    public static ObjectActivator<T> GetActivator<T>(Type type)
    {
        ParameterExpression param =
            Expression.Parameter(typeof(object[]), "args");

        NewExpression newExp = Expression.New(type.GetConstructor(Type.EmptyTypes));

        LambdaExpression lambda =
            Expression.Lambda(typeof(ObjectActivator<T>), newExp, param);

        ObjectActivator<T> compiled = (ObjectActivator<T>)lambda.Compile();
        return compiled;
    }
}