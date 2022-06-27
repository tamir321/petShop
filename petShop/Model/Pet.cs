﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace petShop.Model
{
    /// <summary>
    /// Pet
    /// </summary>
    [DataContract]
    public class Pet
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 1,
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,
            /// <summary>
            /// Enum Sold for value: sold
            /// </summary>
            [EnumMember(Value = "sold")]
            Sold = 3
        }
        /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        public Pet()
        {

        }

        public Pet(long? id = default(long?), string name = default(string), Category category = default(Category), List<string> photoUrls = default(List<string>), List<Tag> tags = default(List<Tag>), StatusEnum? status = default(StatusEnum?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Pet and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "photoUrls" is required (not null)
            if (photoUrls == null)
            {
                throw new InvalidDataException("photoUrls is a required property for Pet and cannot be null");
            }
            else
            {
                this.PhotoUrls = photoUrls;
            }
            this.Id = id;
            this.Category = category;
            this.Tags = tags;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public Category Category { get; set; }

        /// <summary>
        /// Gets or Sets PhotoUrls
        /// </summary>
        [DataMember(Name = "photoUrls", EmitDefaultValue = false)]
        public List<string> PhotoUrls { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<Tag> Tags { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  PhotoUrls: ").Append(PhotoUrls).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Pet);
        }

        /// <summary>
        /// Returns true if Pet instances are equal
        /// </summary>
        /// <param name="input">Instance of Pet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pet input)
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
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) &&
                (
                    this.PhotoUrls == input.PhotoUrls ||
                    this.PhotoUrls != null &&
                    input.PhotoUrls != null &&
                    this.PhotoUrls.SequenceEqual(input.PhotoUrls)
                ) &&
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.PhotoUrls != null)
                    hashCode = hashCode * 59 + this.PhotoUrls.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

        ///// <summary>
        ///// To validate all properties of the instance
        ///// </summary>
        ///// <param name="validationContext">Validation context</param>
        ///// <returns>Validation Result</returns>
        //IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        //{
        //    yield break;
        //}

    }
}
