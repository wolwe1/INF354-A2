//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace u17112631_A2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class lgdepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lgdepartment()
        {
            this.lgemployees = new HashSet<lgemployee>();
        }
    
        public decimal dept_num { get; set; }
        public string dept_name { get; set; }
        public string dept_mail_box { get; set; }
        public string dept_phone { get; set; }
        public Nullable<decimal> emp_num { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lgemployee> lgemployees { get; set; }
        public virtual lgemployee lgemployee { get; set; }
    }
}
