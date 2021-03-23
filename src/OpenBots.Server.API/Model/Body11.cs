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
    /// Body11
    /// </summary>
    [DataContract]
        public partial class Body11 :  IEquatable<Body11>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body11" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="storagePath">storagePath.</param>
        /// <param name="fullStoragePath">fullStoragePath.</param>
        /// <param name="hasChild">hasChild.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="updatedOn">updatedOn.</param>
        /// <param name="isFile">isFile.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="storageDriveId">storageDriveId.</param>
        /// <param name="contentHandle">contentHandle.</param>
        /// <param name="contentCanRead">contentCanRead.</param>
        /// <param name="contentCanWrite">contentCanWrite.</param>
        /// <param name="contentSafeFileHandleIsInvalid">contentSafeFileHandleIsInvalid.</param>
        /// <param name="contentSafeFileHandleIsClosed">contentSafeFileHandleIsClosed.</param>
        /// <param name="contentName">contentName.</param>
        /// <param name="contentIsAsync">contentIsAsync.</param>
        /// <param name="contentLength">contentLength.</param>
        /// <param name="contentPosition">contentPosition.</param>
        /// <param name="contentCanSeek">contentCanSeek.</param>
        /// <param name="contentCanTimeout">contentCanTimeout.</param>
        /// <param name="contentReadTimeout">contentReadTimeout.</param>
        /// <param name="contentWriteTimeout">contentWriteTimeout.</param>
        /// <param name="files">files.</param>
        /// <param name="hash">hash.</param>
        public Body11(Guid? id = default(Guid?), string name = default(string), long? size = default(long?), string storagePath = default(string), string fullStoragePath = default(string), bool? hasChild = default(bool?), string contentType = default(string), string createdBy = default(string), DateTime? createdOn = default(DateTime?), DateTime? updatedOn = default(DateTime?), bool? isFile = default(bool?), Guid? parentId = default(Guid?), Guid? storageDriveId = default(Guid?), IntPtr contentHandle = default(IntPtr), bool? contentCanRead = default(bool?), bool? contentCanWrite = default(bool?), bool? contentSafeFileHandleIsInvalid = default(bool?), bool? contentSafeFileHandleIsClosed = default(bool?), string contentName = default(string), bool? contentIsAsync = default(bool?), long? contentLength = default(long?), long? contentPosition = default(long?), bool? contentCanSeek = default(bool?), bool? contentCanTimeout = default(bool?), int? contentReadTimeout = default(int?), int? contentWriteTimeout = default(int?), List<byte[]> files = default(List<byte[]>), string hash = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Size = size;
            this.StoragePath = storagePath;
            this.FullStoragePath = fullStoragePath;
            this.HasChild = hasChild;
            this.ContentType = contentType;
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
            this.UpdatedOn = updatedOn;
            this.IsFile = isFile;
            this.ParentId = parentId;
            this.StorageDriveId = storageDriveId;
            this.ContentHandle = contentHandle;
            this.ContentCanRead = contentCanRead;
            this.ContentCanWrite = contentCanWrite;
            this.ContentSafeFileHandleIsInvalid = contentSafeFileHandleIsInvalid;
            this.ContentSafeFileHandleIsClosed = contentSafeFileHandleIsClosed;
            this.ContentName = contentName;
            this.ContentIsAsync = contentIsAsync;
            this.ContentLength = contentLength;
            this.ContentPosition = contentPosition;
            this.ContentCanSeek = contentCanSeek;
            this.ContentCanTimeout = contentCanTimeout;
            this.ContentReadTimeout = contentReadTimeout;
            this.ContentWriteTimeout = contentWriteTimeout;
            this.Files = files;
            this.Hash = hash;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or Sets StoragePath
        /// </summary>
        [DataMember(Name="StoragePath", EmitDefaultValue=false)]
        public string StoragePath { get; set; }

        /// <summary>
        /// Gets or Sets FullStoragePath
        /// </summary>
        [DataMember(Name="FullStoragePath", EmitDefaultValue=false)]
        public string FullStoragePath { get; set; }

        /// <summary>
        /// Gets or Sets HasChild
        /// </summary>
        [DataMember(Name="HasChild", EmitDefaultValue=false)]
        public bool? HasChild { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="ContentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

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
        /// Gets or Sets UpdatedOn
        /// </summary>
        [DataMember(Name="UpdatedOn", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Gets or Sets IsFile
        /// </summary>
        [DataMember(Name="IsFile", EmitDefaultValue=false)]
        public bool? IsFile { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="ParentId", EmitDefaultValue=false)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets StorageDriveId
        /// </summary>
        [DataMember(Name="StorageDriveId", EmitDefaultValue=false)]
        public Guid? StorageDriveId { get; set; }

        /// <summary>
        /// Gets or Sets ContentHandle
        /// </summary>
        [DataMember(Name="Content.Handle", EmitDefaultValue=false)]
        public IntPtr ContentHandle { get; set; }

        /// <summary>
        /// Gets or Sets ContentCanRead
        /// </summary>
        [DataMember(Name="Content.CanRead", EmitDefaultValue=false)]
        public bool? ContentCanRead { get; set; }

        /// <summary>
        /// Gets or Sets ContentCanWrite
        /// </summary>
        [DataMember(Name="Content.CanWrite", EmitDefaultValue=false)]
        public bool? ContentCanWrite { get; set; }

        /// <summary>
        /// Gets or Sets ContentSafeFileHandleIsInvalid
        /// </summary>
        [DataMember(Name="Content.SafeFileHandle.IsInvalid", EmitDefaultValue=false)]
        public bool? ContentSafeFileHandleIsInvalid { get; set; }

        /// <summary>
        /// Gets or Sets ContentSafeFileHandleIsClosed
        /// </summary>
        [DataMember(Name="Content.SafeFileHandle.IsClosed", EmitDefaultValue=false)]
        public bool? ContentSafeFileHandleIsClosed { get; set; }

        /// <summary>
        /// Gets or Sets ContentName
        /// </summary>
        [DataMember(Name="Content.Name", EmitDefaultValue=false)]
        public string ContentName { get; set; }

        /// <summary>
        /// Gets or Sets ContentIsAsync
        /// </summary>
        [DataMember(Name="Content.IsAsync", EmitDefaultValue=false)]
        public bool? ContentIsAsync { get; set; }

        /// <summary>
        /// Gets or Sets ContentLength
        /// </summary>
        [DataMember(Name="Content.Length", EmitDefaultValue=false)]
        public long? ContentLength { get; set; }

        /// <summary>
        /// Gets or Sets ContentPosition
        /// </summary>
        [DataMember(Name="Content.Position", EmitDefaultValue=false)]
        public long? ContentPosition { get; set; }

        /// <summary>
        /// Gets or Sets ContentCanSeek
        /// </summary>
        [DataMember(Name="Content.CanSeek", EmitDefaultValue=false)]
        public bool? ContentCanSeek { get; set; }

        /// <summary>
        /// Gets or Sets ContentCanTimeout
        /// </summary>
        [DataMember(Name="Content.CanTimeout", EmitDefaultValue=false)]
        public bool? ContentCanTimeout { get; set; }

        /// <summary>
        /// Gets or Sets ContentReadTimeout
        /// </summary>
        [DataMember(Name="Content.ReadTimeout", EmitDefaultValue=false)]
        public int? ContentReadTimeout { get; set; }

        /// <summary>
        /// Gets or Sets ContentWriteTimeout
        /// </summary>
        [DataMember(Name="Content.WriteTimeout", EmitDefaultValue=false)]
        public int? ContentWriteTimeout { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name="Files", EmitDefaultValue=false)]
        public List<byte[]> Files { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="Hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body11 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  StoragePath: ").Append(StoragePath).Append("\n");
            sb.Append("  FullStoragePath: ").Append(FullStoragePath).Append("\n");
            sb.Append("  HasChild: ").Append(HasChild).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  IsFile: ").Append(IsFile).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  StorageDriveId: ").Append(StorageDriveId).Append("\n");
            sb.Append("  ContentHandle: ").Append(ContentHandle).Append("\n");
            sb.Append("  ContentCanRead: ").Append(ContentCanRead).Append("\n");
            sb.Append("  ContentCanWrite: ").Append(ContentCanWrite).Append("\n");
            sb.Append("  ContentSafeFileHandleIsInvalid: ").Append(ContentSafeFileHandleIsInvalid).Append("\n");
            sb.Append("  ContentSafeFileHandleIsClosed: ").Append(ContentSafeFileHandleIsClosed).Append("\n");
            sb.Append("  ContentName: ").Append(ContentName).Append("\n");
            sb.Append("  ContentIsAsync: ").Append(ContentIsAsync).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  ContentPosition: ").Append(ContentPosition).Append("\n");
            sb.Append("  ContentCanSeek: ").Append(ContentCanSeek).Append("\n");
            sb.Append("  ContentCanTimeout: ").Append(ContentCanTimeout).Append("\n");
            sb.Append("  ContentReadTimeout: ").Append(ContentReadTimeout).Append("\n");
            sb.Append("  ContentWriteTimeout: ").Append(ContentWriteTimeout).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
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
            return this.Equals(input as Body11);
        }

        /// <summary>
        /// Returns true if Body11 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body11 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body11 input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.StoragePath == input.StoragePath ||
                    (this.StoragePath != null &&
                    this.StoragePath.Equals(input.StoragePath))
                ) && 
                (
                    this.FullStoragePath == input.FullStoragePath ||
                    (this.FullStoragePath != null &&
                    this.FullStoragePath.Equals(input.FullStoragePath))
                ) && 
                (
                    this.HasChild == input.HasChild ||
                    (this.HasChild != null &&
                    this.HasChild.Equals(input.HasChild))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
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
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.IsFile == input.IsFile ||
                    (this.IsFile != null &&
                    this.IsFile.Equals(input.IsFile))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.StorageDriveId == input.StorageDriveId ||
                    (this.StorageDriveId != null &&
                    this.StorageDriveId.Equals(input.StorageDriveId))
                ) && 
                (
                    this.ContentHandle == input.ContentHandle ||
                    (this.ContentHandle != null &&
                    this.ContentHandle.Equals(input.ContentHandle))
                ) && 
                (
                    this.ContentCanRead == input.ContentCanRead ||
                    (this.ContentCanRead != null &&
                    this.ContentCanRead.Equals(input.ContentCanRead))
                ) && 
                (
                    this.ContentCanWrite == input.ContentCanWrite ||
                    (this.ContentCanWrite != null &&
                    this.ContentCanWrite.Equals(input.ContentCanWrite))
                ) && 
                (
                    this.ContentSafeFileHandleIsInvalid == input.ContentSafeFileHandleIsInvalid ||
                    (this.ContentSafeFileHandleIsInvalid != null &&
                    this.ContentSafeFileHandleIsInvalid.Equals(input.ContentSafeFileHandleIsInvalid))
                ) && 
                (
                    this.ContentSafeFileHandleIsClosed == input.ContentSafeFileHandleIsClosed ||
                    (this.ContentSafeFileHandleIsClosed != null &&
                    this.ContentSafeFileHandleIsClosed.Equals(input.ContentSafeFileHandleIsClosed))
                ) && 
                (
                    this.ContentName == input.ContentName ||
                    (this.ContentName != null &&
                    this.ContentName.Equals(input.ContentName))
                ) && 
                (
                    this.ContentIsAsync == input.ContentIsAsync ||
                    (this.ContentIsAsync != null &&
                    this.ContentIsAsync.Equals(input.ContentIsAsync))
                ) && 
                (
                    this.ContentLength == input.ContentLength ||
                    (this.ContentLength != null &&
                    this.ContentLength.Equals(input.ContentLength))
                ) && 
                (
                    this.ContentPosition == input.ContentPosition ||
                    (this.ContentPosition != null &&
                    this.ContentPosition.Equals(input.ContentPosition))
                ) && 
                (
                    this.ContentCanSeek == input.ContentCanSeek ||
                    (this.ContentCanSeek != null &&
                    this.ContentCanSeek.Equals(input.ContentCanSeek))
                ) && 
                (
                    this.ContentCanTimeout == input.ContentCanTimeout ||
                    (this.ContentCanTimeout != null &&
                    this.ContentCanTimeout.Equals(input.ContentCanTimeout))
                ) && 
                (
                    this.ContentReadTimeout == input.ContentReadTimeout ||
                    (this.ContentReadTimeout != null &&
                    this.ContentReadTimeout.Equals(input.ContentReadTimeout))
                ) && 
                (
                    this.ContentWriteTimeout == input.ContentWriteTimeout ||
                    (this.ContentWriteTimeout != null &&
                    this.ContentWriteTimeout.Equals(input.ContentWriteTimeout))
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.StoragePath != null)
                    hashCode = hashCode * 59 + this.StoragePath.GetHashCode();
                if (this.FullStoragePath != null)
                    hashCode = hashCode * 59 + this.FullStoragePath.GetHashCode();
                if (this.HasChild != null)
                    hashCode = hashCode * 59 + this.HasChild.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.IsFile != null)
                    hashCode = hashCode * 59 + this.IsFile.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.StorageDriveId != null)
                    hashCode = hashCode * 59 + this.StorageDriveId.GetHashCode();
                if (this.ContentHandle != null)
                    hashCode = hashCode * 59 + this.ContentHandle.GetHashCode();
                if (this.ContentCanRead != null)
                    hashCode = hashCode * 59 + this.ContentCanRead.GetHashCode();
                if (this.ContentCanWrite != null)
                    hashCode = hashCode * 59 + this.ContentCanWrite.GetHashCode();
                if (this.ContentSafeFileHandleIsInvalid != null)
                    hashCode = hashCode * 59 + this.ContentSafeFileHandleIsInvalid.GetHashCode();
                if (this.ContentSafeFileHandleIsClosed != null)
                    hashCode = hashCode * 59 + this.ContentSafeFileHandleIsClosed.GetHashCode();
                if (this.ContentName != null)
                    hashCode = hashCode * 59 + this.ContentName.GetHashCode();
                if (this.ContentIsAsync != null)
                    hashCode = hashCode * 59 + this.ContentIsAsync.GetHashCode();
                if (this.ContentLength != null)
                    hashCode = hashCode * 59 + this.ContentLength.GetHashCode();
                if (this.ContentPosition != null)
                    hashCode = hashCode * 59 + this.ContentPosition.GetHashCode();
                if (this.ContentCanSeek != null)
                    hashCode = hashCode * 59 + this.ContentCanSeek.GetHashCode();
                if (this.ContentCanTimeout != null)
                    hashCode = hashCode * 59 + this.ContentCanTimeout.GetHashCode();
                if (this.ContentReadTimeout != null)
                    hashCode = hashCode * 59 + this.ContentReadTimeout.GetHashCode();
                if (this.ContentWriteTimeout != null)
                    hashCode = hashCode * 59 + this.ContentWriteTimeout.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
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
