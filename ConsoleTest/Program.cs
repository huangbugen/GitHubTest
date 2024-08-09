// using System.Linq.Expressions;

// ParameterExpression parameterExpression1 = Expression.Parameter(typeof(int), "num");
// BinaryExpression binaryExpression1 = Expression.MakeBinary(ExpressionType.Add, parameterExpression1, Expression.Constant(5));
// Expression<Func<int, int>> expression1 = Expression.Lambda<Func<int, int>>(binaryExpression1, parameterExpression1);

// if (expression1.Body.NodeType == ExpressionType.Add)
// {
//     var binaryExpression2 = (BinaryExpression)expression1.Body;

//     Console.WriteLine($"Left Type:{binaryExpression2.Left.GetType()}");
//     Console.WriteLine($"Left NodeType:{binaryExpression2.Left.NodeType}");

//     Console.WriteLine($"Right Type:{binaryExpression2.Right.GetType()}");
//     Console.WriteLine($"Right NodeType:{binaryExpression2.Right.NodeType}");

//     if (binaryExpression2.Left is ParameterExpression binaryExpression3)
//     {
//         Console.WriteLine($"parameterExpression.Name:{binaryExpression3.Name}");
//         Console.WriteLine($"parameterExpression.Type:{binaryExpression3.Type}");
//     }

//     if (binaryExpression2.Right is ConstantExpression constantExpression1)
//     {
//         Console.WriteLine($"constantExpression.Value:{constantExpression1.Value}");
//     }

//     var @delegate1 = expression1.Compile();
//     Console.WriteLine(@delegate1(2));
// }


// using System.Linq.Expressions;
// using ConsoleTest;

// Expression<Func<int, int, int>> exp = (m, n) => m * n + 2;
// System.Console.WriteLine(exp.ToString());

// OperationsVisitor visitor = new OperationsVisitor();
// Expression newExp = visitor.Visit(exp);
// System.Console.WriteLine(newExp.ToString());

// using ConsoleTest;
// using Microsoft.Extensions.Configuration;

// var builder = new ConfigurationBuilder()
//         .SetBasePath(Directory.GetCurrentDirectory())
//         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// var configuration = builder.Build();


// var book = configuration.GetSection(BookOptions.Book).Get<BookOptions>();



// using FluentResults;


// var result = IsInteger("");

// if (result.IsSuccess)
// {
//     Console.WriteLine($"结果：{result.Value} ");
// }
// else
// {
//     Console.WriteLine($"结果：{result.Reasons[0].Message}|{result.Errors[0].Message}");
// }

// static Result<int> IsInteger(string input)
// {
//     // 假设输入为空或null，我们可以选择认为它不是数字  
//     if (string.IsNullOrWhiteSpace(input))
//     {
//         return Result.Fail<int>("输入为空或null，无法判断是否是数字");
//     }

//     // 使用int.TryParse尝试将输入转换为整数  
//     // 如果转换成功，out参数将包含转换后的值，方法返回true  
//     // 如果转换失败，方法返回false
//     if (int.TryParse(input, out int result))
//     {
//         return Result.Ok(result);
//     }

//     // 如果无法转换为整数，则认为输入不是数字  
//     return Result.Fail<int>("输入不是数字");
// }

// object s1 = "Hello"[..2];
// object s2 = "Hello"[..2];
// string str1 = "Hello"[..2];
// string str2 = "Hello"[..2];
// var res1 = s1 == s2;
// var res2 = s1.Equals(s2);
// var res3 = str1 == str2;
// var res4 = str1.Equals(str2);
// System.Console.WriteLine(res1);
// System.Console.WriteLine(res2);
// System.Console.WriteLine(res3);
// System.Console.WriteLine(res4);

object obj = "Hello, World";
if (obj is string str)
{
    System.Console.WriteLine(str);
}
