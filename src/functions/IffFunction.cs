using System;
using System.Linq;
using DevLab.JmesPath.Utils;
using Newtonsoft.Json.Linq;

namespace DevLab.JmesPath.Functions
{
    public sealed class Iff : JmesPathFunction
    {
        public Iff() : base("iff", 3)
        {
        }

        public override JToken Execute(params JmesPathFunctionArgument[] args)
        {
            System.Diagnostics.Debug.Assert(args.Length == 3);
            System.Diagnostics.Debug.Assert(args[0].IsToken);
            System.Diagnostics.Debug.Assert(args[1].IsToken);
            System.Diagnostics.Debug.Assert(args[2].IsToken);

            var booleanResult = Evaluate(args[0]);

            var isFalse = JTokens.IsFalse(booleanResult);
            var expression = JTokens.IsFalse(booleanResult)
                ? args[2]
                : args[1]
                ;

            return Evaluate(expression);
        }

        private static JToken Evaluate(JmesPathFunctionArgument argument)
        {
            return argument.Token;
        }
    }
}