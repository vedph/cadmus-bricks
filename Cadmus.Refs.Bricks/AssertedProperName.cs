namespace Cadmus.Refs.Bricks
{
    /// <summary>
    /// A <see cref="ProperName"/> with an <see cref="Assertion"/>.
    /// </summary>
    public class AssertedProperName : ProperName, IHasAssertion
    {
        /// <summary>
        /// Gets or sets the assertion.
        /// </summary>
        public Assertion Assertion { get; set; }
    }
}
