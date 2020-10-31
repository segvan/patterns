using System;
using System.Collections.Generic;
using System.Linq;
using patterns.library.Models;

namespace patterns.library.Builder
{
    public class FunctionalBuilder : GenericFunctionalBuilder<Person, FunctionalBuilder>
    {
        public FunctionalBuilder Called(string name)
        {
            return Do(p => { p.Name = name; });
        }
    }

    public abstract class GenericFunctionalBuilder<TSub, TSelf>
        where TSub : new()
        where TSelf : GenericFunctionalBuilder<TSub, TSelf>
    {
        private readonly List<Func<TSub, TSub>> Actions
            = new List<Func<TSub, TSub>>();

        public TSelf Do(Action<TSub> action)
        {
            return AddAction(action);
        }

        public TSub Build()
        {
            return Actions.Aggregate(new TSub(), (p, f) => f(p));
        }

        private TSelf AddAction(Action<TSub> action)
        {
            Actions.Add(p =>
            {
                action(p);
                return p;
            });

            return (TSelf) this;
        }
    }

    public static class FunctionalBuilderExtensions
    {
        public static FunctionalBuilder WorksAsA
            (this FunctionalBuilder builder, string position)
        {
            return builder.Do(p => { p.Position = position; });
        }
    }
}