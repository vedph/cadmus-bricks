namespace Cadmus.Refs.Bricks
{
    /// <summary>
    /// A <see cref="ProperName"/> with an <see cref="Assertion"/>.
    /// </summary>
    public class AssertedProperName : IHasAssertion
    {
        /// <summary>
        /// The name.
        /// </summary>
        public ProperName Name { get; set; }

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
            return Name?.ToString() ?? base.ToString();
        }
    }
}
