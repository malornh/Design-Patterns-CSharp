using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    class MoodManager
    {
        private MoodManager() { }

        private static MoodManager _instance;
        private static readonly object _lock = new object();
        public string Mood {  get; private set; }

        public static MoodManager GetInstance(string mood)
        {
            if( _instance == null )
            {
                lock (_lock) // Thread safe
                {
                    if(_instance == null)
                    {
                        _instance = new MoodManager();
                        _instance.Mood = mood;
                    }
                }
            }

            return _instance;
        }

    }
}
