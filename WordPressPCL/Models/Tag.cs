﻿using Newtonsoft.Json;

namespace WordPressPCL.Models
{
    /// <summary>
    /// Terms of the type tag
    /// </summary>
    public class Tag : Term
    {
        /// <summary>
        /// Number of published posts for the term.
        /// </summary>
        /// <remarks>
        /// Read only
        /// Context: view, edit
        /// </remarks>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// HTML description of the term.
        /// </summary>
        /// <remarks>Context: view, edit</remarks>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
