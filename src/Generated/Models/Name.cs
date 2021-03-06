// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BotSociety.Runtime.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Name
    /// </summary>
    public partial class Name
    {
        /// <summary>
        /// Initializes a new instance of the Name class.
        /// </summary>
        public Name()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Name class.
        /// </summary>
        public Name(IList<string> values)
        {
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Values == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Values");
            }
        }
    }
}
