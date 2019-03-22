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
    /// The details required to create a new share update
    /// </summary>
    [DataContract]
    public partial class CreateShareUpdate :  IEquatable<CreateShareUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateShareUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareUpdate" /> class.
        /// </summary>
        /// <param name="Notes">The notes associated with this share update.</param>
        /// <param name="EmailAddressesToAdd">Email addresses of new users to share this shareable item with.</param>
        /// <param name="NotifyAddedUsers">Whether to notify new users that the shareable item has now been shared with them (required).</param>
        /// <param name="AddedUserNotificationMessage">If added users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message..</param>
        /// <param name="EmailAddressesToRemove">Email addresses of users that this shareable item has already been shared with that should be removed from the share.</param>
        /// <param name="NotifyRemovedUsers">Whether to notify existing users that the share has been updated (required).</param>
        /// <param name="RemovedUserNotificationMessage">If removed users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message..</param>
        /// <param name="NotifyUnchangedUsers">Whether to notify users that the shareable item is shared with, but that haven&#39;t   been added or removed that the share has been updated (required).</param>
        /// <param name="UnchangedUserNotificationMessage">If unchanged users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message..</param>
        public CreateShareUpdate(string Notes = default(string), List<string> EmailAddressesToAdd = default(List<string>), bool? NotifyAddedUsers = default(bool?), string AddedUserNotificationMessage = default(string), List<string> EmailAddressesToRemove = default(List<string>), bool? NotifyRemovedUsers = default(bool?), string RemovedUserNotificationMessage = default(string), bool? NotifyUnchangedUsers = default(bool?), string UnchangedUserNotificationMessage = default(string))
        {
            // to ensure "NotifyAddedUsers" is required (not null)
            if (NotifyAddedUsers == null)
            {
                throw new InvalidDataException("NotifyAddedUsers is a required property for CreateShareUpdate and cannot be null");
            }
            else
            {
                this.NotifyAddedUsers = NotifyAddedUsers;
            }
            // to ensure "NotifyRemovedUsers" is required (not null)
            if (NotifyRemovedUsers == null)
            {
                throw new InvalidDataException("NotifyRemovedUsers is a required property for CreateShareUpdate and cannot be null");
            }
            else
            {
                this.NotifyRemovedUsers = NotifyRemovedUsers;
            }
            // to ensure "NotifyUnchangedUsers" is required (not null)
            if (NotifyUnchangedUsers == null)
            {
                throw new InvalidDataException("NotifyUnchangedUsers is a required property for CreateShareUpdate and cannot be null");
            }
            else
            {
                this.NotifyUnchangedUsers = NotifyUnchangedUsers;
            }
            this.Notes = Notes;
            this.EmailAddressesToAdd = EmailAddressesToAdd;
            this.AddedUserNotificationMessage = AddedUserNotificationMessage;
            this.EmailAddressesToRemove = EmailAddressesToRemove;
            this.RemovedUserNotificationMessage = RemovedUserNotificationMessage;
            this.UnchangedUserNotificationMessage = UnchangedUserNotificationMessage;
        }
        
        /// <summary>
        /// The notes associated with this share update
        /// </summary>
        /// <value>The notes associated with this share update</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Email addresses of new users to share this shareable item with
        /// </summary>
        /// <value>Email addresses of new users to share this shareable item with</value>
        [DataMember(Name="emailAddressesToAdd", EmitDefaultValue=false)]
        public List<string> EmailAddressesToAdd { get; set; }

        /// <summary>
        /// Whether to notify new users that the shareable item has now been shared with them
        /// </summary>
        /// <value>Whether to notify new users that the shareable item has now been shared with them</value>
        [DataMember(Name="notifyAddedUsers", EmitDefaultValue=false)]
        public bool? NotifyAddedUsers { get; set; }

        /// <summary>
        /// If added users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message.
        /// </summary>
        /// <value>If added users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message.</value>
        [DataMember(Name="addedUserNotificationMessage", EmitDefaultValue=false)]
        public string AddedUserNotificationMessage { get; set; }

        /// <summary>
        /// Email addresses of users that this shareable item has already been shared with that should be removed from the share
        /// </summary>
        /// <value>Email addresses of users that this shareable item has already been shared with that should be removed from the share</value>
        [DataMember(Name="emailAddressesToRemove", EmitDefaultValue=false)]
        public List<string> EmailAddressesToRemove { get; set; }

        /// <summary>
        /// Whether to notify existing users that the share has been updated
        /// </summary>
        /// <value>Whether to notify existing users that the share has been updated</value>
        [DataMember(Name="notifyRemovedUsers", EmitDefaultValue=false)]
        public bool? NotifyRemovedUsers { get; set; }

        /// <summary>
        /// If removed users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message.
        /// </summary>
        /// <value>If removed users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message.</value>
        [DataMember(Name="removedUserNotificationMessage", EmitDefaultValue=false)]
        public string RemovedUserNotificationMessage { get; set; }

        /// <summary>
        /// Whether to notify users that the shareable item is shared with, but that haven&#39;t   been added or removed that the share has been updated
        /// </summary>
        /// <value>Whether to notify users that the shareable item is shared with, but that haven&#39;t   been added or removed that the share has been updated</value>
        [DataMember(Name="notifyUnchangedUsers", EmitDefaultValue=false)]
        public bool? NotifyUnchangedUsers { get; set; }

        /// <summary>
        /// If unchanged users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message.
        /// </summary>
        /// <value>If unchanged users are to be notified, this is the message to be sent to them.  The URL of the view of the shareable item (specified when the shareable item was created)  will be added to the notification after this message.</value>
        [DataMember(Name="unchangedUserNotificationMessage", EmitDefaultValue=false)]
        public string UnchangedUserNotificationMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateShareUpdate {\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  EmailAddressesToAdd: ").Append(EmailAddressesToAdd).Append("\n");
            sb.Append("  NotifyAddedUsers: ").Append(NotifyAddedUsers).Append("\n");
            sb.Append("  AddedUserNotificationMessage: ").Append(AddedUserNotificationMessage).Append("\n");
            sb.Append("  EmailAddressesToRemove: ").Append(EmailAddressesToRemove).Append("\n");
            sb.Append("  NotifyRemovedUsers: ").Append(NotifyRemovedUsers).Append("\n");
            sb.Append("  RemovedUserNotificationMessage: ").Append(RemovedUserNotificationMessage).Append("\n");
            sb.Append("  NotifyUnchangedUsers: ").Append(NotifyUnchangedUsers).Append("\n");
            sb.Append("  UnchangedUserNotificationMessage: ").Append(UnchangedUserNotificationMessage).Append("\n");
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
            return this.Equals(input as CreateShareUpdate);
        }

        /// <summary>
        /// Returns true if CreateShareUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateShareUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShareUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.EmailAddressesToAdd == input.EmailAddressesToAdd ||
                    this.EmailAddressesToAdd != null &&
                    this.EmailAddressesToAdd.SequenceEqual(input.EmailAddressesToAdd)
                ) && 
                (
                    this.NotifyAddedUsers == input.NotifyAddedUsers ||
                    (this.NotifyAddedUsers != null &&
                    this.NotifyAddedUsers.Equals(input.NotifyAddedUsers))
                ) && 
                (
                    this.AddedUserNotificationMessage == input.AddedUserNotificationMessage ||
                    (this.AddedUserNotificationMessage != null &&
                    this.AddedUserNotificationMessage.Equals(input.AddedUserNotificationMessage))
                ) && 
                (
                    this.EmailAddressesToRemove == input.EmailAddressesToRemove ||
                    this.EmailAddressesToRemove != null &&
                    this.EmailAddressesToRemove.SequenceEqual(input.EmailAddressesToRemove)
                ) && 
                (
                    this.NotifyRemovedUsers == input.NotifyRemovedUsers ||
                    (this.NotifyRemovedUsers != null &&
                    this.NotifyRemovedUsers.Equals(input.NotifyRemovedUsers))
                ) && 
                (
                    this.RemovedUserNotificationMessage == input.RemovedUserNotificationMessage ||
                    (this.RemovedUserNotificationMessage != null &&
                    this.RemovedUserNotificationMessage.Equals(input.RemovedUserNotificationMessage))
                ) && 
                (
                    this.NotifyUnchangedUsers == input.NotifyUnchangedUsers ||
                    (this.NotifyUnchangedUsers != null &&
                    this.NotifyUnchangedUsers.Equals(input.NotifyUnchangedUsers))
                ) && 
                (
                    this.UnchangedUserNotificationMessage == input.UnchangedUserNotificationMessage ||
                    (this.UnchangedUserNotificationMessage != null &&
                    this.UnchangedUserNotificationMessage.Equals(input.UnchangedUserNotificationMessage))
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
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.EmailAddressesToAdd != null)
                    hashCode = hashCode * 59 + this.EmailAddressesToAdd.GetHashCode();
                if (this.NotifyAddedUsers != null)
                    hashCode = hashCode * 59 + this.NotifyAddedUsers.GetHashCode();
                if (this.AddedUserNotificationMessage != null)
                    hashCode = hashCode * 59 + this.AddedUserNotificationMessage.GetHashCode();
                if (this.EmailAddressesToRemove != null)
                    hashCode = hashCode * 59 + this.EmailAddressesToRemove.GetHashCode();
                if (this.NotifyRemovedUsers != null)
                    hashCode = hashCode * 59 + this.NotifyRemovedUsers.GetHashCode();
                if (this.RemovedUserNotificationMessage != null)
                    hashCode = hashCode * 59 + this.RemovedUserNotificationMessage.GetHashCode();
                if (this.NotifyUnchangedUsers != null)
                    hashCode = hashCode * 59 + this.NotifyUnchangedUsers.GetHashCode();
                if (this.UnchangedUserNotificationMessage != null)
                    hashCode = hashCode * 59 + this.UnchangedUserNotificationMessage.GetHashCode();
                return hashCode;
            }
        }
    }

}
