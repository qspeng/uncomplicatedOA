//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seven7c.OA.Model
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class WF_Instance
    {
        public WF_Instance()
        {
            this.WF_Step = new HashSet<WF_Step>();
        }
    
        public int Id { get; set; }
        public int WF_TempId { get; set; }
        public string InstName { get; set; }
        public System.Guid WFApplicationId { get; set; }
        public int SubBy { get; set; }
        public System.DateTime SubTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public short Status { get; set; }
        public short DelFlag { get; set; }
        public string Remark { get; set; }
        public string InstanceForm { get; set; }
    
        public virtual WF_Temp WF_Temp { get; set; }
        public virtual ICollection<WF_Step> WF_Step { get; set; }
    }
}
