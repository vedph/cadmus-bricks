using System.Text;

namespace Cadmus.Refs.Bricks
{
    /// <summary>
    /// The union of an <see cref="AssertedDate"/> and an
    /// <see cref="AssertedPlace"/>.
    /// </summary>
    public class AssertedChronotope
    {
        /// <summary>
        /// The place with its <see cref="Assertion"/>.
        /// </summary>
        public AssertedPlace Place { get; set; }

        /// <summary>
        /// The date with its <see cref="Assertion"/>.
        /// </summary>
        public AssertedDate Date { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>String.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Place != null) sb.Append(Place);
            if (Date != null)
            {
                if (Place != null) sb.Append(", ");
                sb.Append(Date);
            }

            return sb.ToString();
        }
    }
}
