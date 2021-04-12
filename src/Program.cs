
using System;
using System.Threading.Tasks;

namespace Claucometa.DesignPatterns
{
    public class Program
    {
        // LogChain.Program.Run();
        // StateMachine.Program.Run();
        // Bridge.Program.Run();
        // await new Pipe.Program().Run();
        // Money.Program.Run();
        // Adapter.Program.Run();

        static async Task Main(string[] args)
        {
            await new Pipe.Program().Run();

            //Console.ReadLine();
        }
    }
}
