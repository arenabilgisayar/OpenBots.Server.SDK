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
    /// InviteUserViewModel
    /// </summary>
    [DataContract]
        public partial class InviteUserViewModel :  IEquatable<InviteUserViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserViewModel" /> class.
        /// </summary>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="processId">processId.</param>
        /// <param name="email">email (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="company">company.</param>
        /// <param name="department">department.</param>
        /// <param name="shareUrl">shareUrl.</param>
        /// <param name="password">password.</param>
        /// <param name="skipEmailVerification">skipEmailVerification.</param>
        public InviteUserViewModel(Guid? organizationId = default(Guid?), Guid? processId = default(Guid?), string email = default(string), string name = default(string), string company = default(string), string department = default(string), string shareUrl = default(string), string password = default(string), bool? skipEmailVerification = default(bool?))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for InviteUserViewModel and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InviteUserViewModel and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.OrganizationId = organizationId;
            this.ProcessId = processId;
            this.Company = company;
            this.Department = department;
            this.ShareUrl = shareUrl;
            this.Password = password;
            this.SkipEmailVerification = skipEmailVerification;
        }
        
        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessId
        /// </summary>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public Guid? ProcessId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets ShareUrl
        /// </summary>
        [DataMember(Name="shareUrl", EmitDefaultValue=false)]
        public string ShareUrl { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets SkipEmailVerification
        /// </summary>
        [DataMember(Name="skipEmailVerification", EmitDefaultValue=false)]
        public bool? SkipEmailVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteUserViewModel {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  ShareUrl: ").Append(ShareUrl).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SkipEmailVerification: ").Append(SkipEmailVerification).Append("\n");
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
            return this.Equals(input as InviteUserViewModel);
        }

        /// <summary>
        /// Returns true if InviteUserViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteUserViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteUserViewModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.ShareUrl == input.ShareUrl ||
                    (this.ShareUrl != null &&
                    this.ShareUrl.Equals(input.ShareUrl))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SkipEmailVerification == input.SkipEmailVerification ||
                    (this.SkipEmailVerification != null &&
                    this.SkipEmailVerification.Equals(input.SkipEmailVerification))
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
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.ShareUrl != null)
                    hashCode = hashCode * 59 + this.ShareUrl.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SkipEmailVerification != null)
                    hashCode = hashCode * 59 + this.SkipEmailVerification.GetHashCode();
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
