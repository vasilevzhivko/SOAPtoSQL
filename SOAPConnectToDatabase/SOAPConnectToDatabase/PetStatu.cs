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
    public partial class PetStatu
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int PetID { get; set; }
        [DataMember]
        public int StatusID { get; set; }
        [DataMember]
        public int DoctorID { get; set; }
        [DataMember]
        public  Doctor Doctor { get; set; }
        [DataMember]
        public  Pet Pet { get; set; }
        [DataMember]
        public  Status Status { get; set; }
    }
}
