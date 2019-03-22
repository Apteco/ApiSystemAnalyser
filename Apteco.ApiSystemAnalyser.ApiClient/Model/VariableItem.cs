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
    /// Details for a variable in the FastStats system returned as part of the All items endpoint
    /// </summary>
    [DataContract]
    public partial class VariableItem :  IEquatable<VariableItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VariableItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableItem" /> class.
        /// </summary>
        /// <param name="Name">The name of the variable (required).</param>
        /// <param name="Description">The description of the variable (required).</param>
        /// <param name="TableName">The name of the table the variable is on (required).</param>
        public VariableItem(string Name = default(string), string Description = default(string), string TableName = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for VariableItem and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for VariableItem and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "TableName" is required (not null)
            if (TableName == null)
            {
                throw new InvalidDataException("TableName is a required property for VariableItem and cannot be null");
            }
            else
            {
                this.TableName = TableName;
            }
        }
        
        /// <summary>
        /// The name of the variable
        /// </summary>
        /// <value>The name of the variable</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the variable
        /// </summary>
        /// <value>The description of the variable</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the table the variable is on
        /// </summary>
        /// <value>The name of the table the variable is on</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
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
            return this.Equals(input as VariableItem);
        }

        /// <summary>
        /// Returns true if VariableItem instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                return hashCode;
            }
        }
    }

}
