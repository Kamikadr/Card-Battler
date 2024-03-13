using System;

namespace Core
{
    public interface IResultChecker
    {
        event Action OnResultReceived;
    }
}