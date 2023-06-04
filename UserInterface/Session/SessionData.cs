using Domain;

namespace UserInterface.Session
{
    public class SessionData
    {
        private static SessionData _instance;
        private static readonly object LockObject = new object();
        private SessionData() { }
        public static SessionData Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (LockObject)
                {
                    if (_instance == null)
                        _instance = new SessionData();
                }
                return _instance;
            }
        }

        public User User { get; set; }
    }
}
