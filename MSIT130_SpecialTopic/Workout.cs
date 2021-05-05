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
    
    public partial class Workout
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workout()
        {
            this.WorkoutLogs = new HashSet<WorkoutLog>();
        }
    
        public int ID { get; set; }
        public int WorkoutCategoryID { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public int ActivityLevelID { get; set; }
    
        public virtual ActivityLevel ActivityLevel { get; set; }
        public virtual WorkoutCategory WorkoutCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkoutLog> WorkoutLogs { get; set; }
    }
}
