using System;
using System.ComponentModel;

namespace ActuatingForce

{
    public static class SynchronizedInvokeExtension
    {
        public static void SynchronizedInvoke(this ISynchronizeInvoke sync, Action action)
        {
            if (!sync.InvokeRequired)
            {
                action();
                return;
            }
            sync.Invoke(action, new object[] { });
        }
    }
}
