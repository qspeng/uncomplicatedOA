﻿using Seven7c.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven7c.OA.IBLL
{
    public partial interface IWF_TempService:IBaseService<WF_Temp>
    {
        int DeleteTemps(List<int> ids);
    }
}
