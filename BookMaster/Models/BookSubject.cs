//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookMaster.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookSubject
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public Nullable<int> BookId { get; set; }
    
        public virtual Book Book { get; set; }
    }
}
