namespace Zoo.Bootstrap.Wrappers
{
    using System;

    internal class ZooWrapper
    {
        internal static void Initialize()
        {
            while (!Environment.HasShutdownStarted)
            {
                //TODO Provide the criteria switching mechanism (based on flags?)
            }
        }
    }
}
