﻿namespace DownKyi.Models
{
    public class AppInfo
    {
        public string Name { get; } = "哔哩下载姬";
        public int VersionCode { get; } = 500;

#if DEBUG
        public string VersionName { get; } = "1.5.0-alpha1 Debug";
#else
        public string VersionName { get; } = "1.5.0-alpha1";
#endif

    }
}
