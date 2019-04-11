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
    /// Options
    /// </summary>
    public partial class Options
    {
        /// <summary>
        /// Initializes a new instance of the Options class.
        /// </summary>
        public Options()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Options class.
        /// </summary>
        public Options(bool showWelcomeScreen, bool showTypingIndicators, bool showKeyboard, string backgroundColor)
        {
            ShowWelcomeScreen = showWelcomeScreen;
            ShowTypingIndicators = showTypingIndicators;
            ShowKeyboard = showKeyboard;
            BackgroundColor = backgroundColor;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "showWelcomeScreen")]
        public bool ShowWelcomeScreen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "showTypingIndicators")]
        public bool ShowTypingIndicators { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "showKeyboard")]
        public bool ShowKeyboard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BackgroundColor == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BackgroundColor");
            }
        }
    }
}
