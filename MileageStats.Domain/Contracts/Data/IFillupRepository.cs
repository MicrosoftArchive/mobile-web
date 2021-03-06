/*  
Copyright Microsoft Corporation

Licensed under the Apache License, Version 2.0 (the "License"); you may not
use this file except in compliance with the License. You may obtain a copy of
the License at 

http://www.apache.org/licenses/LICENSE-2.0 

THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED 
WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, 
MERCHANTABLITY OR NON-INFRINGEMENT. 

See the Apache 2 License for the specific language governing permissions and
limitations under the License. */

using System.Collections.Generic;
using MileageStats.Domain.Models;


namespace MileageStats.Domain.Contracts.Data
{
    public interface IFillupRepository
    {
        void Create(int userId, int vehicleId, FillupEntry fillup);

        FillupEntry GetFillup(int fillupId);
        IEnumerable<FillupEntry> GetFillups(int vehicleId);
    }
}