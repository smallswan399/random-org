﻿using System;

namespace Community.RandomOrg.Data
{
    /// <summary>Represents an object describing the license terms under which the random values given in the data can be used.</summary>
    public sealed class License
    {
        internal License()
        {
        }

        /// <summary>Gets or sets license type.</summary>
        public string Type { get; set; }

        /// <summary>Gets or sets license description.</summary>
        public string Text { get; set; }

        /// <summary>Gets or sets an URL with license information.</summary>
        public Uri InfoUrl { get; set; }
    }
}