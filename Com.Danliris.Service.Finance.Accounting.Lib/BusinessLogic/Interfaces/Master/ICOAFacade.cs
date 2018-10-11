﻿using Com.Danliris.Service.Finance.Accounting.Lib.Models.MasterCOA;
using Com.Danliris.Service.Finance.Accounting.Lib.Utilities.BaseInterface;
using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.MasterCOA;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.Master
{
    public interface ICOAFacade : IBaseFacade<COAModel>
    {
        Task UploadData(List<COAViewModel> data);
    }
}
