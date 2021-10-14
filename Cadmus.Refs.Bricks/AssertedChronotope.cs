namespace Cadmus.Refs.Bricks
{
    /// <summary>
    /// A <see cref="Chronotope"/> with an <see cref="Assertion"/>.
    /// </summary>
    public class AssertedChronotope : Chronotope, IHasAssertion
    {
        /// <summary>
        /// Gets or sets the assertion.
        /// </summary>
        public Assertion Assertion { get; set; }
    }
}
