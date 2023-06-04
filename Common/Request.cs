using System;

namespace Common
{
    [Serializable]
    public class Request
    {
        public object RequestObject { get; set; }
        public Operation Operation { get; set; }

    }
}
