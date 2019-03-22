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
    /// The details of the email requirements within the user configuration
    /// </summary>
    [DataContract]
    public partial class EmailRequirements :  IEquatable<EmailRequirements>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRequirements" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailRequirements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRequirements" /> class.
        /// </summary>
        /// <param name="AllowUnrestrictedEmailDomains">Whether the domains of email addresses used to create users or share to users will  be checked against the list of RestrictedEmailDomains (required).</param>
        /// <param name="RestrictedEmailDomains">The list of valid email domains available for creating user or sharing with users  If AllowUnrestrictedEmailDomains is false and an attempt is made to create a user  or share to a user with an email address that has a domain not in the list then an  error will be returned. (required).</param>
        public EmailRequirements(bool? AllowUnrestrictedEmailDomains = default(bool?), List<string> RestrictedEmailDomains = default(List<string>))
        {
            // to ensure "AllowUnrestrictedEmailDomains" is required (not null)
            if (AllowUnrestrictedEmailDomains == null)
            {
                throw new InvalidDataException("AllowUnrestrictedEmailDomains is a required property for EmailRequirements and cannot be null");
            }
            else
            {
                this.AllowUnrestrictedEmailDomains = AllowUnrestrictedEmailDomains;
            }
            // to ensure "RestrictedEmailDomains" is required (not null)
            if (RestrictedEmailDomains == null)
            {
                throw new InvalidDataException("RestrictedEmailDomains is a required property for EmailRequirements and cannot be null");
            }
            else
            {
                this.RestrictedEmailDomains = RestrictedEmailDomains;
            }
        }
        
        /// <summary>
        /// Whether the domains of email addresses used to create users or share to users will  be checked against the list of RestrictedEmailDomains
        /// </summary>
        /// <value>Whether the domains of email addresses used to create users or share to users will  be checked against the list of RestrictedEmailDomains</value>
        [DataMember(Name="allowUnrestrictedEmailDomains", EmitDefaultValue=false)]
        public bool? AllowUnrestrictedEmailDomains { get; set; }

        /// <summary>
        /// The list of valid email domains available for creating user or sharing with users  If AllowUnrestrictedEmailDomains is false and an attempt is made to create a user  or share to a user with an email address that has a domain not in the list then an  error will be returned.
        /// </summary>
        /// <value>The list of valid email domains available for creating user or sharing with users  If AllowUnrestrictedEmailDomains is false and an attempt is made to create a user  or share to a user with an email address that has a domain not in the list then an  error will be returned.</value>
        [DataMember(Name="restrictedEmailDomains", EmitDefaultValue=false)]
        public List<string> RestrictedEmailDomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailRequirements {\n");
            sb.Append("  AllowUnrestrictedEmailDomains: ").Append(AllowUnrestrictedEmailDomains).Append("\n");
            sb.Append("  RestrictedEmailDomains: ").Append(RestrictedEmailDomains).Append("\n");
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
            return this.Equals(input as EmailRequirements);
        }

        /// <summary>
        /// Returns true if EmailRequirements instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailRequirements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailRequirements input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowUnrestrictedEmailDomains == input.AllowUnrestrictedEmailDomains ||
                    (this.AllowUnrestrictedEmailDomains != null &&
                    this.AllowUnrestrictedEmailDomains.Equals(input.AllowUnrestrictedEmailDomains))
                ) && 
                (
                    this.RestrictedEmailDomains == input.RestrictedEmailDomains ||
                    this.RestrictedEmailDomains != null &&
                    this.RestrictedEmailDomains.SequenceEqual(input.RestrictedEmailDomains)
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
                if (this.AllowUnrestrictedEmailDomains != null)
                    hashCode = hashCode * 59 + this.AllowUnrestrictedEmailDomains.GetHashCode();
                if (this.RestrictedEmailDomains != null)
                    hashCode = hashCode * 59 + this.RestrictedEmailDomains.GetHashCode();
                return hashCode;
            }
        }
    }

}
