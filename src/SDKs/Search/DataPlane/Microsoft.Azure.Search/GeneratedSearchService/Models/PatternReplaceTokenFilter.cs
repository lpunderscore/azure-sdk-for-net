// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A character filter that replaces characters in the input string. It
    /// uses a regular expression to identify character sequences to preserve
    /// and a replacement pattern to identify characters to replace. For
    /// example, given the input text "aa bb aa bb", pattern "(aa)\s+(bb)", and
    /// replacement "$1#$2", the result would be "aa#bb aa#bb". This token
    /// filter is implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/pattern/PatternReplaceFilter.html" />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.PatternReplaceTokenFilter")]
    public partial class PatternReplaceTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the PatternReplaceTokenFilter class.
        /// </summary>
        public PatternReplaceTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the PatternReplaceTokenFilter class.
        /// </summary>
        /// <param name="name">The name of the token filter. It must only
        /// contain letters, digits, spaces, dashes or underscores, can only
        /// start and end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="pattern">A regular expression pattern.</param>
        /// <param name="replacement">The replacement text.</param>
        public PatternReplaceTokenFilter(string name, string pattern, string replacement)
            : base(name)
        {
            Pattern = pattern;
            Replacement = replacement;
        }

        /// <summary>
        /// Gets or sets a regular expression pattern.
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets the replacement text.
        /// </summary>
        [JsonProperty(PropertyName = "replacement")]
        public string Replacement { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Pattern == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Pattern");
            }
            if (Replacement == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Replacement");
            }
        }
    }
}

