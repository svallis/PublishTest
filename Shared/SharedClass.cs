using System;

namespace Shared
{
    public class SharedClass
    {
        public void Test()
        {
            Framework.FrameworkClass.Test();

            var test = new Framework.FrameworkClass();
        }
    }
}
