//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Travel_Notes
    {
        public System.Guid Id { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<System.DateTime> DeteletedAt { get; set; }
        public Nullable<int> WriterId { get; set; }
        public string Test { get; set; }
        public bool Deleted { get; set; }
        public Nullable<System.Guid> PlaceId { get; set; }
    }
}
