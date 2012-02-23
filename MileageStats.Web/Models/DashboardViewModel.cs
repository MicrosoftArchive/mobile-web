/*  
Copyright Microsoft Corporation

Licensed under the Apache License, Version 2.0 (the "License"); you may not
use this file except in compliance with the License. You may obtain a copy of
the License at 

http://www.apache.org/licenses/LICENSE-2.0 

THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED 
ARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, 
MERCHANTABLITY OR NON-INFRINGEMENT. 

See the Apache 2 License for the specific language governing permissions and
limitations under the License. */

using System.Collections.Generic;
using MileageStats.Domain.Models;

namespace MileageStats.Web.Models
{
    public class DashboardViewModel
    {
        public User User { get; set; }

        public VehicleListViewModel VehicleListViewModel { get; set; }

        public IEnumerable<ImminentReminderModel> ImminentReminders { get; set; }

        public FleetStatistics FleetSummaryStatistics { get; set; }
    }
}