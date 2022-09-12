using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class OutBoundedException : Exception
{
    public int _monthInput { get; }

    public OutBoundedException() { }

    public OutBoundedException(string message)
        : base(message) { }
}