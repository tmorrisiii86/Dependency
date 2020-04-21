using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency1
{
    class FlexWorker
    {
        private ITool _someTool;

        public FlexWorker(ITool toolToUse)
        {
            _someTool = toolToUse;
        }

        public void DoSomeWork()
        {
            _someTool.UseTool();
        }
    }
}
