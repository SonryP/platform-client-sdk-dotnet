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
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ArchitectDependencyTrackingBuildNotificationUser
    /// </summary>
    [DataContract]
    public partial class ArchitectDependencyTrackingBuildNotificationUser :  IEquatable<ArchitectDependencyTrackingBuildNotificationUser>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectDependencyTrackingBuildNotificationUser" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="HomeOrg">HomeOrg.</param>
        public ArchitectDependencyTrackingBuildNotificationUser(string Id = null, string Name = null, ArchitectDependencyTrackingBuildNotificationHomeOrganization HomeOrg = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.HomeOrg = HomeOrg;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets HomeOrg
        /// </summary>
        [DataMember(Name="homeOrg", EmitDefaultValue=false)]
        public ArchitectDependencyTrackingBuildNotificationHomeOrganization HomeOrg { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectDependencyTrackingBuildNotificationUser {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HomeOrg: ").Append(HomeOrg).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ArchitectDependencyTrackingBuildNotificationUser);
        }

        /// <summary>
        /// Returns true if ArchitectDependencyTrackingBuildNotificationUser instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectDependencyTrackingBuildNotificationUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectDependencyTrackingBuildNotificationUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.HomeOrg == other.HomeOrg ||
                    this.HomeOrg != null &&
                    this.HomeOrg.Equals(other.HomeOrg)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.HomeOrg != null)
                    hash = hash * 59 + this.HomeOrg.GetHashCode();
                
                return hash;
            }
        }
    }

}