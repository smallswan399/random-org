﻿using System;
using System.Diagnostics;
using System.Globalization;
using Community.RandomOrg.Data;

namespace Community.RandomOrg.UnitTests.Internal
{
    [DebuggerStepThrough]
    internal static class RandomOrgConvert
    {
        public static DateTime StringToDateTime(string value)
        {
            return DateTime.ParseExact(value, "yyyy'-'MM'-'dd' 'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
        }

        public static ApiKeyStatus StringToApiKeyStatus(string value)
        {
            switch (value)
            {
                case "stopped":
                    {
                        return ApiKeyStatus.Stopped;
                    }
                case "paused":
                    {
                        return ApiKeyStatus.Paused;
                    }
                case "running":
                    {
                        return ApiKeyStatus.Running;
                    }
                default:
                    {
                        throw new ArgumentException($"The specified value is not supported: \"{value}\"", nameof(value));
                    }
            }
        }
    }
}