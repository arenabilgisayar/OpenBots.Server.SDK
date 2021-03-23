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
    /// Body3
    /// </summary>
    [DataContract]
        public partial class Body3 :  IEquatable<Body3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body3" /> class.
        /// </summary>
        /// <param name="versionNumber">versionNumber.</param>
        /// <param name="versionId">versionId.</param>
        /// <param name="status">status.</param>
        /// <param name="_file">_file.</param>
        /// <param name="fileId">fileId.</param>
        /// <param name="originalPackageName">originalPackageName.</param>
        /// <param name="publishedBy">publishedBy.</param>
        /// <param name="publishedOnUTC">publishedOnUTC.</param>
        /// <param name="automationEngine">automationEngine.</param>
        /// <param name="driveName">driveName.</param>
        /// <param name="automtationParameters">automtationParameters.</param>
        /// <param name="name">name (required).</param>
        /// <param name="id">id.</param>
        /// <param name="isDeleted">isDeleted (default to false).</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="deletedBy">deletedBy.</param>
        /// <param name="deleteOn">deleteOn.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="updatedOn">updatedOn.</param>
        /// <param name="updatedBy">updatedBy.</param>
        public Body3(int? versionNumber = default(int?), Guid? versionId = default(Guid?), string status = default(string), byte[] _file = default(byte[]), Guid? fileId = default(Guid?), string originalPackageName = default(string), string publishedBy = default(string), DateTime? publishedOnUTC = default(DateTime?), string automationEngine = default(string), string driveName = default(string), List<AutomationParameter> automtationParameters = default(List<AutomationParameter>), string name = default(string), Guid? id = default(Guid?), bool? isDeleted = false, string createdBy = default(string), DateTime? createdOn = default(DateTime?), string deletedBy = default(string), DateTime? deleteOn = default(DateTime?), byte[] timestamp = default(byte[]), DateTime? updatedOn = default(DateTime?), string updatedBy = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Body3 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.VersionNumber = versionNumber;
            this.VersionId = versionId;
            this.Status = status;
            this.File = _file;
            this.FileId = fileId;
            this.OriginalPackageName = originalPackageName;
            this.PublishedBy = publishedBy;
            this.PublishedOnUTC = publishedOnUTC;
            this.AutomationEngine = automationEngine;
            this.DriveName = driveName;
            this.AutomtationParameters = automtationParameters;
            this.Id = id;
            // use default value if no "isDeleted" provided
            if (isDeleted == null)
            {
                this.IsDeleted = false;
            }
            else
            {
                this.IsDeleted = isDeleted;
            }
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
            this.DeletedBy = deletedBy;
            this.DeleteOn = deleteOn;
            this.Timestamp = timestamp;
            this.UpdatedOn = updatedOn;
            this.UpdatedBy = updatedBy;
        }
        
        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name="VersionNumber", EmitDefaultValue=false)]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets VersionId
        /// </summary>
        [DataMember(Name="VersionId", EmitDefaultValue=false)]
        public Guid? VersionId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="File", EmitDefaultValue=false)]
        public byte[] File { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public Guid? FileId { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPackageName
        /// </summary>
        [DataMember(Name="OriginalPackageName", EmitDefaultValue=false)]
        public string OriginalPackageName { get; set; }

        /// <summary>
        /// Gets or Sets PublishedBy
        /// </summary>
        [DataMember(Name="PublishedBy", EmitDefaultValue=false)]
        public string PublishedBy { get; set; }

        /// <summary>
        /// Gets or Sets PublishedOnUTC
        /// </summary>
        [DataMember(Name="PublishedOnUTC", EmitDefaultValue=false)]
        public DateTime? PublishedOnUTC { get; set; }

        /// <summary>
        /// Gets or Sets AutomationEngine
        /// </summary>
        [DataMember(Name="AutomationEngine", EmitDefaultValue=false)]
        public string AutomationEngine { get; set; }

        /// <summary>
        /// Gets or Sets DriveName
        /// </summary>
        [DataMember(Name="DriveName", EmitDefaultValue=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// Gets or Sets AutomtationParameters
        /// </summary>
        [DataMember(Name="AutomtationParameters", EmitDefaultValue=false)]
        public List<AutomationParameter> AutomtationParameters { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name="IsDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="CreatedOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets DeletedBy
        /// </summary>
        [DataMember(Name="DeletedBy", EmitDefaultValue=false)]
        public string DeletedBy { get; set; }

        /// <summary>
        /// Gets or Sets DeleteOn
        /// </summary>
        [DataMember(Name="DeleteOn", EmitDefaultValue=false)]
        public DateTime? DeleteOn { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public byte[] Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedOn
        /// </summary>
        [DataMember(Name="UpdatedOn", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name="UpdatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body3 {\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  OriginalPackageName: ").Append(OriginalPackageName).Append("\n");
            sb.Append("  PublishedBy: ").Append(PublishedBy).Append("\n");
            sb.Append("  PublishedOnUTC: ").Append(PublishedOnUTC).Append("\n");
            sb.Append("  AutomationEngine: ").Append(AutomationEngine).Append("\n");
            sb.Append("  DriveName: ").Append(DriveName).Append("\n");
            sb.Append("  AutomtationParameters: ").Append(AutomtationParameters).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  DeleteOn: ").Append(DeleteOn).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
            return this.Equals(input as Body3);
        }

        /// <summary>
        /// Returns true if Body3 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.OriginalPackageName == input.OriginalPackageName ||
                    (this.OriginalPackageName != null &&
                    this.OriginalPackageName.Equals(input.OriginalPackageName))
                ) && 
                (
                    this.PublishedBy == input.PublishedBy ||
                    (this.PublishedBy != null &&
                    this.PublishedBy.Equals(input.PublishedBy))
                ) && 
                (
                    this.PublishedOnUTC == input.PublishedOnUTC ||
                    (this.PublishedOnUTC != null &&
                    this.PublishedOnUTC.Equals(input.PublishedOnUTC))
                ) && 
                (
                    this.AutomationEngine == input.AutomationEngine ||
                    (this.AutomationEngine != null &&
                    this.AutomationEngine.Equals(input.AutomationEngine))
                ) && 
                (
                    this.DriveName == input.DriveName ||
                    (this.DriveName != null &&
                    this.DriveName.Equals(input.DriveName))
                ) && 
                (
                    this.AutomtationParameters == input.AutomtationParameters ||
                    this.AutomtationParameters != null &&
                    input.AutomtationParameters != null &&
                    this.AutomtationParameters.SequenceEqual(input.AutomtationParameters)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DeletedBy == input.DeletedBy ||
                    (this.DeletedBy != null &&
                    this.DeletedBy.Equals(input.DeletedBy))
                ) && 
                (
                    this.DeleteOn == input.DeleteOn ||
                    (this.DeleteOn != null &&
                    this.DeleteOn.Equals(input.DeleteOn))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
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
                if (this.VersionNumber != null)
                    hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.VersionId != null)
                    hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.OriginalPackageName != null)
                    hashCode = hashCode * 59 + this.OriginalPackageName.GetHashCode();
                if (this.PublishedBy != null)
                    hashCode = hashCode * 59 + this.PublishedBy.GetHashCode();
                if (this.PublishedOnUTC != null)
                    hashCode = hashCode * 59 + this.PublishedOnUTC.GetHashCode();
                if (this.AutomationEngine != null)
                    hashCode = hashCode * 59 + this.AutomationEngine.GetHashCode();
                if (this.DriveName != null)
                    hashCode = hashCode * 59 + this.DriveName.GetHashCode();
                if (this.AutomtationParameters != null)
                    hashCode = hashCode * 59 + this.AutomtationParameters.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DeletedBy != null)
                    hashCode = hashCode * 59 + this.DeletedBy.GetHashCode();
                if (this.DeleteOn != null)
                    hashCode = hashCode * 59 + this.DeleteOn.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
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
