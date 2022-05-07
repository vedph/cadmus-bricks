using Fusi.Antiquity.Chronology;
using System;

namespace Cadmus.Refs.Bricks
{
    /// <summary>
    /// A <see cref="HistoricalDate"/> with an <see cref="Assertion"/>.
    /// </summary>
    public class AssertedDate : HistoricalDate, IHasAssertion
    {
        /// <summary>
        /// Gets or sets the optional tag. This is an arbitrary value used
        /// to classify or group dates.
        /// </summary>
        public string? Tag { get; set; }

        /// <summary>
        /// Gets or sets the assertion.
        /// </summary>
        public Assertion? Assertion { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertedDate"/> class.
        /// </summary>
        public AssertedDate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertedDate"/> class.
        /// </summary>
        /// <param name="date">The date to set for this asserted date.</param>
        /// <exception cref="ArgumentNullException">date</exception>
        public AssertedDate(HistoricalDate date)
        {
            if (date is null) throw new ArgumentNullException(nameof(date));

            A = date.A;
            B = date.B;
        }
    }
}
