//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Events()
        {
            this.Activities = new HashSet<Activities>();
        }
    
        public int IdEvents { get; set; }
        public string NameEvent { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Days { get; set; }
        public Nullable<int> IdCity { get; set; }
        public Nullable<int> IdUserWinner { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activities> Activities { get; set; }
        public virtual City City { get; set; }
        public virtual Users Users { get; set; }
    }
}
