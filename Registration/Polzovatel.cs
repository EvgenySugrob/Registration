//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registration
{
    using System;
    using System.Collections.Generic;
    
    public partial class Polzovatel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Polzovatel()
        {
            this.Persona = new HashSet<Persona>();
        }
    
        public int CodePolzovately { get; set; }
        public string Login { get; set; }
        public string Parol { get; set; }
        public Nullable<int> KodeDolznosty { get; set; }
    
        public virtual Dolznost Dolznost { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
