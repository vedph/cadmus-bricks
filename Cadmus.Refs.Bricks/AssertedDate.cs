﻿using Fusi.Antiquity.Chronology;

namespace Cadmus.Refs.Bricks
{
    /// <summary>
    /// A <see cref="HistoricalDate"/> with an <see cref="Assertion"/>.
    /// </summary>
    public class AssertedDate : IHasAssertion
    {
        /// <summary>
        /// Gets or sets the optional tag. This is an arbitrary value used
        /// to classify or group chronotopes.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public HistoricalDate Value { get; set; }

        /// <summary>
        /// Gets or sets the assertion.
        /// </summary>
        public Assertion Assertion { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>String.</returns>
        public override string ToString()
        {
            return Value?.ToString() ?? base.ToString();
        }
    }
}
