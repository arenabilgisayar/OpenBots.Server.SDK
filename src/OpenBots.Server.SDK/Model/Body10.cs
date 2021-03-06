/* 
 * OpenBots Server API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = OpenBots.Server.SDK.Client.SwaggerDateConverter;

namespace OpenBots.Server.SDK.Model
{
    /// <summary>
    /// Body10
    /// </summary>
    [DataContract]
        public partial class Body10 :  IEquatable<Body10>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body10" /> class.
        /// </summary>
        /// <param name="sentOnUTC">sentOnUTC.</param>
        /// <param name="emailObjectJson">emailObjectJson.</param>
        /// <param name="senderName">senderName.</param>
        /// <param name="senderAddress">senderAddress.</param>
        /// <param name="senderUserId">senderUserId.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">reason.</param>
        /// <param name="direction">direction.</param>
        /// <param name="conversationId">conversationId.</param>
        /// <param name="replyToEmailId">replyToEmailId.</param>
        /// <param name="emailAccountId">emailAccountId.</param>
        /// <param name="files">files.</param>
        /// <param name="driveName">driveName.</param>
        public Body10(DateTime? sentOnUTC = default(DateTime?), string emailObjectJson = default(string), string senderName = default(string), string senderAddress = default(string), Guid? senderUserId = default(Guid?), string status = default(string), string reason = default(string), string direction = default(string), Guid? conversationId = default(Guid?), Guid? replyToEmailId = default(Guid?), Guid? emailAccountId = default(Guid?), List<byte[]> files = default(List<byte[]>), string driveName = default(string))
        {
            this.SentOnUTC = sentOnUTC;
            this.EmailObjectJson = emailObjectJson;
            this.SenderName = senderName;
            this.SenderAddress = senderAddress;
            this.SenderUserId = senderUserId;
            this.Status = status;
            this.Reason = reason;
            this.Direction = direction;
            this.ConversationId = conversationId;
            this.ReplyToEmailId = replyToEmailId;
            this.EmailAccountId = emailAccountId;
            this.Files = files;
            this.DriveName = driveName;
        }
        
        /// <summary>
        /// Gets or Sets SentOnUTC
        /// </summary>
        [DataMember(Name="SentOnUTC", EmitDefaultValue=false)]
        public DateTime? SentOnUTC { get; set; }

        /// <summary>
        /// Gets or Sets EmailObjectJson
        /// </summary>
        [DataMember(Name="EmailObjectJson", EmitDefaultValue=false)]
        public string EmailObjectJson { get; set; }

        /// <summary>
        /// Gets or Sets SenderName
        /// </summary>
        [DataMember(Name="SenderName", EmitDefaultValue=false)]
        public string SenderName { get; set; }

        /// <summary>
        /// Gets or Sets SenderAddress
        /// </summary>
        [DataMember(Name="SenderAddress", EmitDefaultValue=false)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// Gets or Sets SenderUserId
        /// </summary>
        [DataMember(Name="SenderUserId", EmitDefaultValue=false)]
        public Guid? SenderUserId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="Direction", EmitDefaultValue=false)]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="ConversationId", EmitDefaultValue=false)]
        public Guid? ConversationId { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToEmailId
        /// </summary>
        [DataMember(Name="ReplyToEmailId", EmitDefaultValue=false)]
        public Guid? ReplyToEmailId { get; set; }

        /// <summary>
        /// Gets or Sets EmailAccountId
        /// </summary>
        [DataMember(Name="EmailAccountId", EmitDefaultValue=false)]
        public Guid? EmailAccountId { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name="Files", EmitDefaultValue=false)]
        public List<byte[]> Files { get; set; }

        /// <summary>
        /// Gets or Sets DriveName
        /// </summary>
        [DataMember(Name="DriveName", EmitDefaultValue=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body10 {\n");
            sb.Append("  SentOnUTC: ").Append(SentOnUTC).Append("\n");
            sb.Append("  EmailObjectJson: ").Append(EmailObjectJson).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
            sb.Append("  SenderUserId: ").Append(SenderUserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ReplyToEmailId: ").Append(ReplyToEmailId).Append("\n");
            sb.Append("  EmailAccountId: ").Append(EmailAccountId).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  DriveName: ").Append(DriveName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Body10);
        }

        /// <summary>
        /// Returns true if Body10 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body10 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body10 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SentOnUTC == input.SentOnUTC ||
                    (this.SentOnUTC != null &&
                    this.SentOnUTC.Equals(input.SentOnUTC))
                ) && 
                (
                    this.EmailObjectJson == input.EmailObjectJson ||
                    (this.EmailObjectJson != null &&
                    this.EmailObjectJson.Equals(input.EmailObjectJson))
                ) && 
                (
                    this.SenderName == input.SenderName ||
                    (this.SenderName != null &&
                    this.SenderName.Equals(input.SenderName))
                ) && 
                (
                    this.SenderAddress == input.SenderAddress ||
                    (this.SenderAddress != null &&
                    this.SenderAddress.Equals(input.SenderAddress))
                ) && 
                (
                    this.SenderUserId == input.SenderUserId ||
                    (this.SenderUserId != null &&
                    this.SenderUserId.Equals(input.SenderUserId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.ConversationId == input.ConversationId ||
                    (this.ConversationId != null &&
                    this.ConversationId.Equals(input.ConversationId))
                ) && 
                (
                    this.ReplyToEmailId == input.ReplyToEmailId ||
                    (this.ReplyToEmailId != null &&
                    this.ReplyToEmailId.Equals(input.ReplyToEmailId))
                ) && 
                (
                    this.EmailAccountId == input.EmailAccountId ||
                    (this.EmailAccountId != null &&
                    this.EmailAccountId.Equals(input.EmailAccountId))
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                ) && 
                (
                    this.DriveName == input.DriveName ||
                    (this.DriveName != null &&
                    this.DriveName.Equals(input.DriveName))
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
                if (this.SentOnUTC != null)
                    hashCode = hashCode * 59 + this.SentOnUTC.GetHashCode();
                if (this.EmailObjectJson != null)
                    hashCode = hashCode * 59 + this.EmailObjectJson.GetHashCode();
                if (this.SenderName != null)
                    hashCode = hashCode * 59 + this.SenderName.GetHashCode();
                if (this.SenderAddress != null)
                    hashCode = hashCode * 59 + this.SenderAddress.GetHashCode();
                if (this.SenderUserId != null)
                    hashCode = hashCode * 59 + this.SenderUserId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.ConversationId != null)
                    hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
                if (this.ReplyToEmailId != null)
                    hashCode = hashCode * 59 + this.ReplyToEmailId.GetHashCode();
                if (this.EmailAccountId != null)
                    hashCode = hashCode * 59 + this.EmailAccountId.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.DriveName != null)
                    hashCode = hashCode * 59 + this.DriveName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
