//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSIT130_SpecialTopic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.DietLogs = new HashSet<DietLog>();
            this.Preferences = new HashSet<Preference>();
            this.WeightLogs = new HashSet<WeightLog>();
            this.WorkoutLogs = new HashSet<WorkoutLog>();
        }
    
        public int ID { get; set; }
        public string TaiwanID { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public bool IsAdmin { get; set; }
        public System.DateTime Birthdate { get; set; }
        public System.DateTime JoinDate { get; set; }
        public byte[] Image { get; set; }
        public int StatusID { get; set; }
        public int ActivityLevelID { get; set; }
    
        public virtual ActivityLevel ActivityLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DietLog> DietLogs { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Preference> Preferences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeightLog> WeightLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkoutLog> WorkoutLogs { get; set; }
    }
}
