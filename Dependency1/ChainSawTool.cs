using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency1
{
    class ChainSawTool : ITool
    {
        public void UseTool()
        {
            Console.WriteLine("The ChainSaw tool is put to work!");
        }
    }
}
