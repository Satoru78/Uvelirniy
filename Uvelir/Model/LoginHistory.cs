//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uvelir.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoginHistory
    {
        public Nullable<int> IDUser { get; set; }
        public System.DateTime LoginTime { get; set; }
        public Nullable<int> ErrorCount { get; set; }
        public Nullable<int> ID { get; set; }
    
        public virtual User User { get; set; }
    }
}