//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Burtsev_PR315_Lombard
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProdutSell
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> IdWorkMan { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> IdProduct { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual Workman Workman { get; set; }
    }
}