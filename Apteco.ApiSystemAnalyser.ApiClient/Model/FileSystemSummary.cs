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
    /// Top level summary for filesystem information
    /// </summary>
    [DataContract]
    public partial class FileSystemSummary :  IEquatable<FileSystemSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileSystemSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemSummary" /> class.
        /// </summary>
        /// <param name="SystemName">The name of the system that has a filesystem available (required).</param>
        public FileSystemSummary(string SystemName = default(string))
        {
            // to ensure "SystemName" is required (not null)
            if (SystemName == null)
            {
                throw new InvalidDataException("SystemName is a required property for FileSystemSummary and cannot be null");
            }
            else
            {
                this.SystemName = SystemName;
            }
        }
        
        /// <summary>
        /// The name of the system that has a filesystem available
        /// </summary>
        /// <value>The name of the system that has a filesystem available</value>
        [DataMember(Name="systemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileSystemSummary {\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
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
            return this.Equals(input as FileSystemSummary);
        }

        /// <summary>
        /// Returns true if FileSystemSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of FileSystemSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileSystemSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
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
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                return hashCode;
            }
        }
    }

}
