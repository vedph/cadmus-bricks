using System.Text;

namespace Cadmus.Bricks
{
    /// <summary>
    /// A generic ID from an external resource.
    /// </summary>
    public class ExternalId
    {
        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets an optional type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets an optional tag.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets an optional note.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(Value)) sb.Append('#').Append(Value);
            if (!string.IsNullOrEmpty(Type)) sb.Append(" [").Append(Tag).Append(']');
            return sb.ToString();
        }
    }
}
