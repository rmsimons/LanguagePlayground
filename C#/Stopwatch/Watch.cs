using System;

namespace Stopwatch
{
    class Watch
    {
        private static DateTime? _start = null;
        private static DateTime _end;

        public static TimeSpan Duration { get; private set; }
        public static void Start()
        {
            if (_start.HasValue)
            {
                throw new InvalidOperationException("Watch is already started");
            }

            _start = DateTime.Now;
        }

        public static void End()
        {
            if (!_start.HasValue)
            {
                throw new InvalidOperationException("Watch has not been started");
            } else
            {
                _end = DateTime.Now;
                Duration = _end - (DateTime)_start;
                _start = null;
            }
        }
    }
}
