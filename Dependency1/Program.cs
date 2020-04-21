using System;

namespace Dependency1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker myWorker = new Worker();
            myWorker.UseShovel();
            
            FlexWorker officeWorker = new FlexWorker(new SpreadSheetComputerTool());
            officeWorker.DoSomeWork();

            FlexWorker plumber = new FlexWorker(new PipeCutterTool());
            plumber.DoSomeWork();

            FlexWorker leatherFace = new FlexWorker(new ChainSawTool());
            leatherFace.DoSomeWork();
        }
    }
}
