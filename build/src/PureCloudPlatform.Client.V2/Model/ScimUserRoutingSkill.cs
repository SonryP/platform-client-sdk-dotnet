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
    /// Routing skill assigned to user.
    /// </summary>
    [DataContract]
    public partial class ScimUserRoutingSkill :  IEquatable<ScimUserRoutingSkill>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUserRoutingSkill" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScimUserRoutingSkill() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUserRoutingSkill" /> class.
        /// </summary>
        /// <param name="Name">Case-sensitive name identifying a skill configured in routing skills. (required).</param>
        /// <param name="Proficiency">Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings..</param>
        public ScimUserRoutingSkill(string Name = null, double? Proficiency = null)
        {
            this.Name = Name;
            this.Proficiency = Proficiency;
            
        }
        
        
        
        /// <summary>
        /// Case-sensitive name identifying a skill configured in routing skills.
        /// </summary>
        /// <value>Case-sensitive name identifying a skill configured in routing skills.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings.
        /// </summary>
        /// <value>Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings.</value>
        [DataMember(Name="proficiency", EmitDefaultValue=false)]
        public double? Proficiency { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimUserRoutingSkill {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Proficiency: ").Append(Proficiency).Append("\n");
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
            return this.Equals(obj as ScimUserRoutingSkill);
        }

        /// <summary>
        /// Returns true if ScimUserRoutingSkill instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimUserRoutingSkill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimUserRoutingSkill other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Proficiency == other.Proficiency ||
                    this.Proficiency != null &&
                    this.Proficiency.Equals(other.Proficiency)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Proficiency != null)
                    hash = hash * 59 + this.Proficiency.GetHashCode();
                
                return hash;
            }
        }
    }

}