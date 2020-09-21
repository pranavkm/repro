using System;
using System.Diagnostics;
using System.Runtime.Versioning;

namespace foo
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert(OperatingSystem.IsWindows());
            Unsupported();
        }

        [UnsupportedOSPlatform("windows")]
        static void Unsupported()
        {

        }
    }
}
