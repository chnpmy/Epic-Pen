using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epic_Pen.util
{
    class TimeStamp
    {
        public static int Current = GetCurrentTimeStamp();
        /**
         * 得到当前时间相对于1970/1/1的时间戳，以秒为单位，可保证在公元2038年前不会溢出
         */
        private static int GetCurrentTimeStamp()
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0));
            TimeSpan delta = DateTime.Now.Subtract(startTime);
            return Convert.ToInt32(Math.Round(delta.TotalSeconds, MidpointRounding.AwayFromZero));
        }
    }
}
