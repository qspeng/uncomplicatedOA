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
    public partial class WF_Temp
    {
        public WF_Temp()
        {
            this.WF_Instance = new HashSet<WF_Instance>();
        }
    
        public int Id { get; set; }
        public string TempName { get; set; }
        public short DelFlag { get; set; }
        public string Remark { get; set; }
        public string Description { get; set; }
        public string TempForm { get; set; }
        public string WFActivity { get; set; }
    
        public virtual ICollection<WF_Instance> WF_Instance { get; set; }
    }
}