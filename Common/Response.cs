using System;

namespace Common
{
    [Serializable]
    public class Response
    {
        public string Message { get; set; }
        public bool IsSuccessful { get; set; } = true;
        public object Result { get; set; }

    }
}
