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
    /// Details for a PeopleStage Channel
    /// </summary>
    [DataContract]
    public partial class ChannelDetail :  IEquatable<ChannelDetail>
    {
        /// <summary>
        /// The channel&#39;s type
        /// </summary>
        /// <value>The channel&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Control for value: Control
            /// </summary>
            [EnumMember(Value = "Control")]
            Control = 2,
            
            /// <summary>
            /// Enum Broadcast for value: Broadcast
            /// </summary>
            [EnumMember(Value = "Broadcast")]
            Broadcast = 3,
            
            /// <summary>
            /// Enum File for value: File
            /// </summary>
            [EnumMember(Value = "File")]
            File = 4,
            
            /// <summary>
            /// Enum Ftp for value: Ftp
            /// </summary>
            [EnumMember(Value = "Ftp")]
            Ftp = 5,
            
            /// <summary>
            /// Enum Facebook for value: Facebook
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook = 6,
            
            /// <summary>
            /// Enum MicrosoftDynamics for value: MicrosoftDynamics
            /// </summary>
            [EnumMember(Value = "MicrosoftDynamics")]
            MicrosoftDynamics = 7,
            
            /// <summary>
            /// Enum SalesForce for value: SalesForce
            /// </summary>
            [EnumMember(Value = "SalesForce")]
            SalesForce = 8,
            
            /// <summary>
            /// Enum PushNotification for value: PushNotification
            /// </summary>
            [EnumMember(Value = "PushNotification")]
            PushNotification = 9,
            
            /// <summary>
            /// Enum Twitter for value: Twitter
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter = 10,
            
            /// <summary>
            /// Enum Google for value: Google
            /// </summary>
            [EnumMember(Value = "Google")]
            Google = 11,
            
            /// <summary>
            /// Enum Composite for value: Composite
            /// </summary>
            [EnumMember(Value = "Composite")]
            Composite = 12
        }

        /// <summary>
        /// The channel&#39;s type
        /// </summary>
        /// <value>The channel&#39;s type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelDetail" /> class.
        /// </summary>
        /// <param name="Id">The channel&#39;s id (required).</param>
        /// <param name="SchemaId">The channel&#39;s \&quot;schema id\&quot;, used for looking up information about the channel in the run history of PeopleStage.</param>
        /// <param name="Description">The channel&#39;s description (required).</param>
        /// <param name="Type">The channel&#39;s type (required).</param>
        /// <param name="ParentId">The id of the channel&#39;s parent.</param>
        public ChannelDetail(string Id = default(string), int? SchemaId = default(int?), string Description = default(string), TypeEnum Type = default(TypeEnum), string ParentId = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ChannelDetail and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ChannelDetail and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ChannelDetail and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.SchemaId = SchemaId;
            this.ParentId = ParentId;
        }
        
        /// <summary>
        /// The channel&#39;s id
        /// </summary>
        /// <value>The channel&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The channel&#39;s \&quot;schema id\&quot;, used for looking up information about the channel in the run history of PeopleStage
        /// </summary>
        /// <value>The channel&#39;s \&quot;schema id\&quot;, used for looking up information about the channel in the run history of PeopleStage</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public int? SchemaId { get; set; }

        /// <summary>
        /// The channel&#39;s description
        /// </summary>
        /// <value>The channel&#39;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The id of the channel&#39;s parent
        /// </summary>
        /// <value>The id of the channel&#39;s parent</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
            return this.Equals(input as ChannelDetail);
        }

        /// <summary>
        /// Returns true if ChannelDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SchemaId == input.SchemaId ||
                    (this.SchemaId != null &&
                    this.SchemaId.Equals(input.SchemaId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SchemaId != null)
                    hashCode = hashCode * 59 + this.SchemaId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                return hashCode;
            }
        }
    }

}
