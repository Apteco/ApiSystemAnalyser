/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Apteco.ApiSystemAnalyser.ApiClient.Client.SwaggerDateConverter;

namespace Apteco.ApiSystemAnalyser.ApiClient.Model
{
    /// <summary>
    /// The details of the password requirements within the user configuration
    /// </summary>
    [DataContract]
    public partial class PasswordRequirements :  IEquatable<PasswordRequirements>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordRequirements" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordRequirements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordRequirements" /> class.
        /// </summary>
        /// <param name="MinimumPasswordLength">The minimum number of characters required for a new password (required).</param>
        /// <param name="MinimumNumberOfDigitsInPassword">The minimum number of numeric digit characters required in a new password (required).</param>
        /// <param name="MinimumNumberOfLettersInPassword">The minimum number of alphabetic characters required in a new password (required).</param>
        /// <param name="MinimumNumberOfLowercaseLettersInPassword">The minimum number of lowercase characters required in a new password (required).</param>
        /// <param name="MinimumNumberOfUppercaseLettersInPassword">The minimum number of uppercase characters required in a new password (required).</param>
        /// <param name="MinimumNumberOfSymbolsInPassword">The minimum number of symbols (i.e. not digits or letters) required in a new password (required).</param>
        public PasswordRequirements(int? MinimumPasswordLength = default(int?), int? MinimumNumberOfDigitsInPassword = default(int?), int? MinimumNumberOfLettersInPassword = default(int?), int? MinimumNumberOfLowercaseLettersInPassword = default(int?), int? MinimumNumberOfUppercaseLettersInPassword = default(int?), int? MinimumNumberOfSymbolsInPassword = default(int?))
        {
            // to ensure "MinimumPasswordLength" is required (not null)
            if (MinimumPasswordLength == null)
            {
                throw new InvalidDataException("MinimumPasswordLength is a required property for PasswordRequirements and cannot be null");
            }
            else
            {
                this.MinimumPasswordLength = MinimumPasswordLength;
            }
            // to ensure "MinimumNumberOfDigitsInPassword" is required (not null)
            if (MinimumNumberOfDigitsInPassword == null)
            {
                throw new InvalidDataException("MinimumNumberOfDigitsInPassword is a required property for PasswordRequirements and cannot be null");
            }
            else
            {
                this.MinimumNumberOfDigitsInPassword = MinimumNumberOfDigitsInPassword;
            }
            // to ensure "MinimumNumberOfLettersInPassword" is required (not null)
            if (MinimumNumberOfLettersInPassword == null)
            {
                throw new InvalidDataException("MinimumNumberOfLettersInPassword is a required property for PasswordRequirements and cannot be null");
            }
            else
            {
                this.MinimumNumberOfLettersInPassword = MinimumNumberOfLettersInPassword;
            }
            // to ensure "MinimumNumberOfLowercaseLettersInPassword" is required (not null)
            if (MinimumNumberOfLowercaseLettersInPassword == null)
            {
                throw new InvalidDataException("MinimumNumberOfLowercaseLettersInPassword is a required property for PasswordRequirements and cannot be null");
            }
            else
            {
                this.MinimumNumberOfLowercaseLettersInPassword = MinimumNumberOfLowercaseLettersInPassword;
            }
            // to ensure "MinimumNumberOfUppercaseLettersInPassword" is required (not null)
            if (MinimumNumberOfUppercaseLettersInPassword == null)
            {
                throw new InvalidDataException("MinimumNumberOfUppercaseLettersInPassword is a required property for PasswordRequirements and cannot be null");
            }
            else
            {
                this.MinimumNumberOfUppercaseLettersInPassword = MinimumNumberOfUppercaseLettersInPassword;
            }
            // to ensure "MinimumNumberOfSymbolsInPassword" is required (not null)
            if (MinimumNumberOfSymbolsInPassword == null)
            {
                throw new InvalidDataException("MinimumNumberOfSymbolsInPassword is a required property for PasswordRequirements and cannot be null");
            }
            else
            {
                this.MinimumNumberOfSymbolsInPassword = MinimumNumberOfSymbolsInPassword;
            }
        }
        
        /// <summary>
        /// The minimum number of characters required for a new password
        /// </summary>
        /// <value>The minimum number of characters required for a new password</value>
        [DataMember(Name="minimumPasswordLength", EmitDefaultValue=false)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// The minimum number of numeric digit characters required in a new password
        /// </summary>
        /// <value>The minimum number of numeric digit characters required in a new password</value>
        [DataMember(Name="minimumNumberOfDigitsInPassword", EmitDefaultValue=false)]
        public int? MinimumNumberOfDigitsInPassword { get; set; }

        /// <summary>
        /// The minimum number of alphabetic characters required in a new password
        /// </summary>
        /// <value>The minimum number of alphabetic characters required in a new password</value>
        [DataMember(Name="minimumNumberOfLettersInPassword", EmitDefaultValue=false)]
        public int? MinimumNumberOfLettersInPassword { get; set; }

        /// <summary>
        /// The minimum number of lowercase characters required in a new password
        /// </summary>
        /// <value>The minimum number of lowercase characters required in a new password</value>
        [DataMember(Name="minimumNumberOfLowercaseLettersInPassword", EmitDefaultValue=false)]
        public int? MinimumNumberOfLowercaseLettersInPassword { get; set; }

        /// <summary>
        /// The minimum number of uppercase characters required in a new password
        /// </summary>
        /// <value>The minimum number of uppercase characters required in a new password</value>
        [DataMember(Name="minimumNumberOfUppercaseLettersInPassword", EmitDefaultValue=false)]
        public int? MinimumNumberOfUppercaseLettersInPassword { get; set; }

        /// <summary>
        /// The minimum number of symbols (i.e. not digits or letters) required in a new password
        /// </summary>
        /// <value>The minimum number of symbols (i.e. not digits or letters) required in a new password</value>
        [DataMember(Name="minimumNumberOfSymbolsInPassword", EmitDefaultValue=false)]
        public int? MinimumNumberOfSymbolsInPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordRequirements {\n");
            sb.Append("  MinimumPasswordLength: ").Append(MinimumPasswordLength).Append("\n");
            sb.Append("  MinimumNumberOfDigitsInPassword: ").Append(MinimumNumberOfDigitsInPassword).Append("\n");
            sb.Append("  MinimumNumberOfLettersInPassword: ").Append(MinimumNumberOfLettersInPassword).Append("\n");
            sb.Append("  MinimumNumberOfLowercaseLettersInPassword: ").Append(MinimumNumberOfLowercaseLettersInPassword).Append("\n");
            sb.Append("  MinimumNumberOfUppercaseLettersInPassword: ").Append(MinimumNumberOfUppercaseLettersInPassword).Append("\n");
            sb.Append("  MinimumNumberOfSymbolsInPassword: ").Append(MinimumNumberOfSymbolsInPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PasswordRequirements);
        }

        /// <summary>
        /// Returns true if PasswordRequirements instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordRequirements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordRequirements input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinimumPasswordLength == input.MinimumPasswordLength ||
                    (this.MinimumPasswordLength != null &&
                    this.MinimumPasswordLength.Equals(input.MinimumPasswordLength))
                ) && 
                (
                    this.MinimumNumberOfDigitsInPassword == input.MinimumNumberOfDigitsInPassword ||
                    (this.MinimumNumberOfDigitsInPassword != null &&
                    this.MinimumNumberOfDigitsInPassword.Equals(input.MinimumNumberOfDigitsInPassword))
                ) && 
                (
                    this.MinimumNumberOfLettersInPassword == input.MinimumNumberOfLettersInPassword ||
                    (this.MinimumNumberOfLettersInPassword != null &&
                    this.MinimumNumberOfLettersInPassword.Equals(input.MinimumNumberOfLettersInPassword))
                ) && 
                (
                    this.MinimumNumberOfLowercaseLettersInPassword == input.MinimumNumberOfLowercaseLettersInPassword ||
                    (this.MinimumNumberOfLowercaseLettersInPassword != null &&
                    this.MinimumNumberOfLowercaseLettersInPassword.Equals(input.MinimumNumberOfLowercaseLettersInPassword))
                ) && 
                (
                    this.MinimumNumberOfUppercaseLettersInPassword == input.MinimumNumberOfUppercaseLettersInPassword ||
                    (this.MinimumNumberOfUppercaseLettersInPassword != null &&
                    this.MinimumNumberOfUppercaseLettersInPassword.Equals(input.MinimumNumberOfUppercaseLettersInPassword))
                ) && 
                (
                    this.MinimumNumberOfSymbolsInPassword == input.MinimumNumberOfSymbolsInPassword ||
                    (this.MinimumNumberOfSymbolsInPassword != null &&
                    this.MinimumNumberOfSymbolsInPassword.Equals(input.MinimumNumberOfSymbolsInPassword))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MinimumPasswordLength != null)
                    hashCode = hashCode * 59 + this.MinimumPasswordLength.GetHashCode();
                if (this.MinimumNumberOfDigitsInPassword != null)
                    hashCode = hashCode * 59 + this.MinimumNumberOfDigitsInPassword.GetHashCode();
                if (this.MinimumNumberOfLettersInPassword != null)
                    hashCode = hashCode * 59 + this.MinimumNumberOfLettersInPassword.GetHashCode();
                if (this.MinimumNumberOfLowercaseLettersInPassword != null)
                    hashCode = hashCode * 59 + this.MinimumNumberOfLowercaseLettersInPassword.GetHashCode();
                if (this.MinimumNumberOfUppercaseLettersInPassword != null)
                    hashCode = hashCode * 59 + this.MinimumNumberOfUppercaseLettersInPassword.GetHashCode();
                if (this.MinimumNumberOfSymbolsInPassword != null)
                    hashCode = hashCode * 59 + this.MinimumNumberOfSymbolsInPassword.GetHashCode();
                return hashCode;
            }
        }
    }

}
