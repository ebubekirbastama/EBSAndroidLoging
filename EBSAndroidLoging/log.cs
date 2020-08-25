using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBSAndroidLoging
{
    public class log
    {
       public static string[] komutlar = {
            "shell ps",
            "shell ls -all",
            "shell netstat",
            "shell getprop",
            "logcat -d",
            "shell bugreport",
            "shell dumpsys",
            "shell dumpsys activity",
            "shell dumpsys meminfo",
            "shell cat /proc/cpuinfo",
            "shell cat /proc/meminfo"
        };
    }
}
