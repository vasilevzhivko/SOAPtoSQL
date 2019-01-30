//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPConnectToDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Pet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet()
        {
            this.PetStatus = new HashSet<PetStatu>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int OwnerID { get; set; }
        [DataMember]
        public int AnimalTypeID { get; set; }
        [DataMember]
        public int AnimalSubTypeID { get; set; }
        [DataMember]

        public  AnimalSubType AnimalSubType { get; set; }
        [DataMember]
        public  AnimalType AnimalType { get; set; }
        [DataMember]
        public  Owner Owner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public  ICollection<PetStatu> PetStatus { get; set; }
    }
}
