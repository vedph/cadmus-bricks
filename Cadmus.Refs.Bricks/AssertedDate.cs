using Fusi.Antiquity.Chronology;

namespace Cadmus.Refs.Bricks
{
    /// <summary>
    /// A <see cref="HistoricalDate"/> with an <see cref="Assertion"/>.
    /// </summary>
    public class AssertedDate : HistoricalDate, IHasAssertion
    {
        /// <summary>
        /// Gets or sets the optional tag. This is an arbitrary value used
        /// to classify or group chronotopes.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets the assertion.
        /// </summary>
        public Assertion Assertion { get; set; }
    }
}
