//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace doedusam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_1
    {
        public int id { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string code { get; set; }
        public string C4 { get; set; }
    
        public virtual Таблица1 Таблица1 { get; set; }
        public virtual Таблица2 Таблица2 { get; set; }
    }
}
