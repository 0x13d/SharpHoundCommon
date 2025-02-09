﻿namespace SharpHoundCommonLib
{
    public class LDAPConfig
    {
        public string Username { get; set; } = null;
        public string Password { get; set; } = null;
        public string Server { get; set; } = null;
        public int Port { get; set; } = 0;
        public bool SSL { get; set; } = false;
        public bool DisableSigning { get; set; } = false;

        public int GetPort()
        {
            return Port == 0 ? SSL ? 636 : 389 : Port;
        }
    }
}