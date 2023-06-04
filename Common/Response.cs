using System;

namespace Common
{
    [Serializable]
    public class Response
    {
        public string Message { get; set; }
        public bool IsSuccesful { get; set; } = true;
        public object Result { get; set; }

    }
}
