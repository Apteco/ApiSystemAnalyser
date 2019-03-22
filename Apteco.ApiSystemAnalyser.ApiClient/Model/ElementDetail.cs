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
    /// Details for a PeopleStage Element
    /// </summary>
    [DataContract]
    public partial class ElementDetail :  IEquatable<ElementDetail>
    {
        /// <summary>
        /// The element&#39;s type
        /// </summary>
        /// <value>The element&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Diagram for value: Diagram
            /// </summary>
            [EnumMember(Value = "Diagram")]
            Diagram = 2,
            
            /// <summary>
            /// Enum Programme for value: Programme
            /// </summary>
            [EnumMember(Value = "Programme")]
            Programme = 3,
            
            /// <summary>
            /// Enum Area for value: Area
            /// </summary>
            [EnumMember(Value = "Area")]
            Area = 4,
            
            /// <summary>
            /// Enum Campaign for value: Campaign
            /// </summary>
            [EnumMember(Value = "Campaign")]
            Campaign = 5,
            
            /// <summary>
            /// Enum Message for value: Message
            /// </summary>
            [EnumMember(Value = "Message")]
            Message = 6,
            
            /// <summary>
            /// Enum Group for value: Group
            /// </summary>
            [EnumMember(Value = "Group")]
            Group = 7,
            
            /// <summary>
            /// Enum Audience for value: Audience
            /// </summary>
            [EnumMember(Value = "Audience")]
            Audience = 8,
            
            /// <summary>
            /// Enum Content for value: Content
            /// </summary>
            [EnumMember(Value = "Content")]
            Content = 9,
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 10,
            
            /// <summary>
            /// Enum Pool for value: Pool
            /// </summary>
            [EnumMember(Value = "Pool")]
            Pool = 11,
            
            /// <summary>
            /// Enum Responses for value: Responses
            /// </summary>
            [EnumMember(Value = "Responses")]
            Responses = 12,
            
            /// <summary>
            /// Enum Transition for value: Transition
            /// </summary>
            [EnumMember(Value = "Transition")]
            Transition = 13,
            
            /// <summary>
            /// Enum PauseAction for value: PauseAction
            /// </summary>
            [EnumMember(Value = "PauseAction")]
            PauseAction = 14
        }

        /// <summary>
        /// The element&#39;s type
        /// </summary>
        /// <value>The element&#39;s type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The type of the element&#39;s schema id - if it has a schema id.  Published elements should have a schema id and type.
        /// </summary>
        /// <value>The type of the element&#39;s schema id - if it has a schema id.  Published elements should have a schema id and type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemaIdTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum ProcessId for value: ProcessId
            /// </summary>
            [EnumMember(Value = "ProcessId")]
            ProcessId = 2
        }

        /// <summary>
        /// The type of the element&#39;s schema id - if it has a schema id.  Published elements should have a schema id and type.
        /// </summary>
        /// <value>The type of the element&#39;s schema id - if it has a schema id.  Published elements should have a schema id and type.</value>
        [DataMember(Name="schemaIdType", EmitDefaultValue=false)]
        public SchemaIdTypeEnum? SchemaIdType { get; set; }
        /// <summary>
        /// The parent of this element&#39;s type
        /// </summary>
        /// <value>The parent of this element&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ParentTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Diagram for value: Diagram
            /// </summary>
            [EnumMember(Value = "Diagram")]
            Diagram = 2,
            
            /// <summary>
            /// Enum Programme for value: Programme
            /// </summary>
            [EnumMember(Value = "Programme")]
            Programme = 3,
            
            /// <summary>
            /// Enum Area for value: Area
            /// </summary>
            [EnumMember(Value = "Area")]
            Area = 4,
            
            /// <summary>
            /// Enum Campaign for value: Campaign
            /// </summary>
            [EnumMember(Value = "Campaign")]
            Campaign = 5,
            
            /// <summary>
            /// Enum Message for value: Message
            /// </summary>
            [EnumMember(Value = "Message")]
            Message = 6,
            
            /// <summary>
            /// Enum Group for value: Group
            /// </summary>
            [EnumMember(Value = "Group")]
            Group = 7,
            
            /// <summary>
            /// Enum Audience for value: Audience
            /// </summary>
            [EnumMember(Value = "Audience")]
            Audience = 8,
            
            /// <summary>
            /// Enum Content for value: Content
            /// </summary>
            [EnumMember(Value = "Content")]
            Content = 9,
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 10,
            
            /// <summary>
            /// Enum Pool for value: Pool
            /// </summary>
            [EnumMember(Value = "Pool")]
            Pool = 11,
            
            /// <summary>
            /// Enum Responses for value: Responses
            /// </summary>
            [EnumMember(Value = "Responses")]
            Responses = 12,
            
            /// <summary>
            /// Enum Transition for value: Transition
            /// </summary>
            [EnumMember(Value = "Transition")]
            Transition = 13,
            
            /// <summary>
            /// Enum PauseAction for value: PauseAction
            /// </summary>
            [EnumMember(Value = "PauseAction")]
            PauseAction = 14
        }

        /// <summary>
        /// The parent of this element&#39;s type
        /// </summary>
        /// <value>The parent of this element&#39;s type</value>
        [DataMember(Name="parentType", EmitDefaultValue=false)]
        public ParentTypeEnum ParentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElementDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementDetail" /> class.
        /// </summary>
        /// <param name="Id">The element&#39;s id (required).</param>
        /// <param name="Description">The element&#39;s description (required).</param>
        /// <param name="Type">The element&#39;s type (required).</param>
        /// <param name="SchemaId">The element&#39;s schema id - if it has one.  This is the key field into the PeopleStage schema tables such as ProcessDefinition.  Published elements should have a schema id..</param>
        /// <param name="SchemaIdType">The type of the element&#39;s schema id - if it has a schema id.  Published elements should have a schema id and type..</param>
        /// <param name="ParentId">The parent of this element&#39;s id (required).</param>
        /// <param name="ParentType">The parent of this element&#39;s type (required).</param>
        public ElementDetail(string Id = default(string), string Description = default(string), TypeEnum Type = default(TypeEnum), int? SchemaId = default(int?), SchemaIdTypeEnum? SchemaIdType = default(SchemaIdTypeEnum?), string ParentId = default(string), ParentTypeEnum ParentType = default(ParentTypeEnum))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ElementDetail and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ElementDetail and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ElementDetail and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "ParentId" is required (not null)
            if (ParentId == null)
            {
                throw new InvalidDataException("ParentId is a required property for ElementDetail and cannot be null");
            }
            else
            {
                this.ParentId = ParentId;
            }
            // to ensure "ParentType" is required (not null)
            if (ParentType == null)
            {
                throw new InvalidDataException("ParentType is a required property for ElementDetail and cannot be null");
            }
            else
            {
                this.ParentType = ParentType;
            }
            this.SchemaId = SchemaId;
            this.SchemaIdType = SchemaIdType;
        }
        
        /// <summary>
        /// The element&#39;s id
        /// </summary>
        /// <value>The element&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The element&#39;s description
        /// </summary>
        /// <value>The element&#39;s description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// The element&#39;s schema id - if it has one.  This is the key field into the PeopleStage schema tables such as ProcessDefinition.  Published elements should have a schema id.
        /// </summary>
        /// <value>The element&#39;s schema id - if it has one.  This is the key field into the PeopleStage schema tables such as ProcessDefinition.  Published elements should have a schema id.</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public int? SchemaId { get; set; }


        /// <summary>
        /// The parent of this element&#39;s id
        /// </summary>
        /// <value>The parent of this element&#39;s id</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElementDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  SchemaIdType: ").Append(SchemaIdType).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  ParentType: ").Append(ParentType).Append("\n");
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
            return this.Equals(input as ElementDetail);
        }

        /// <summary>
        /// Returns true if ElementDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ElementDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElementDetail input)
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
                    this.SchemaId == input.SchemaId ||
                    (this.SchemaId != null &&
                    this.SchemaId.Equals(input.SchemaId))
                ) && 
                (
                    this.SchemaIdType == input.SchemaIdType ||
                    (this.SchemaIdType != null &&
                    this.SchemaIdType.Equals(input.SchemaIdType))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.ParentType == input.ParentType ||
                    (this.ParentType != null &&
                    this.ParentType.Equals(input.ParentType))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SchemaId != null)
                    hashCode = hashCode * 59 + this.SchemaId.GetHashCode();
                if (this.SchemaIdType != null)
                    hashCode = hashCode * 59 + this.SchemaIdType.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ParentType != null)
                    hashCode = hashCode * 59 + this.ParentType.GetHashCode();
                return hashCode;
            }
        }
    }

}
