// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BotSociety.Runtime.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Variable
    /// </summary>
    public partial class Variable
    {
        /// <summary>
        /// Initializes a new instance of the Variable class.
        /// </summary>
        public Variable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Variable class.
        /// </summary>
        public Variable(Name name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public Name Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                Name.Validate();
            }
        }
    }
}
