using Patterns.PipesAndFilters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Claucometa.DesignPatterns.Pipe
{
    public class Program
    {
        public async Task Run()
        {
            var result = await new Pipeline<string>()
                .Add(new AddText("123"))
                .Add(new ReverseText())
                .Add(new Pause(TimeSpan.FromMilliseconds(500)))
                .ExecuteAsync(null);

            Console.WriteLine(result);
        }

        public class AddText : SyncFilterBase<string>
        {
            private readonly string txt;

            public AddText(string txt)
            {
                this.txt = txt;
            }

            protected override string OnExecute(string input)
            {
                return input + txt;
            }
        }

        public class ReverseText : SyncFilterBase<string>
        {
            protected override string OnExecute(string input)
            {
                return new string(input.Reverse().ToArray());
            }
        }

        public class Pause : AsyncFilterBase<string>
        {
            private readonly TimeSpan _timeToPause;

            public Pause(TimeSpan timeToPause)
            {
                _timeToPause = timeToPause;
            }

            protected override async Task<string> OnExecuteAsync(string input, CancellationToken cancellationToken)
            {
                await Task.Delay(_timeToPause, cancellationToken);
                return input;
            }
        }
    }
}
