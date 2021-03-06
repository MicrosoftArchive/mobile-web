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

using System;
using MileageStats.Web.ClientProfile;
using Xunit;
using System.Web;

namespace MileageStats.Web.Tests.ClientProfile
{
    public class ProfileCookieEncoderFixture
    {
        [Fact]
        public void WhenGettingDeviceCapabilitiesFromValidCookie_ThenCapabilitiesDictionaryIsReturned()
        {
            var cookieValue = "{'id':'generic','version':'1.1','json':'1','width':'865','height':'500','clr':'24'}";
            var cookie = new HttpCookie("profile", cookieValue);
            var encoder = new ProfileCookieEncoder();

            var capabilities = encoder.GetDeviceCapabilities(cookie);

            Assert.Equal(6, capabilities.Count);
        }

        [Fact]
        public void WhenGettingDeviceCapabilitiesFromInvalidCookie_ThenInvalidOperationExceptionIsThrown()
        {
            var cookieValue = "test";
            var cookie = new HttpCookie("profile", cookieValue);
            var encoder = new ProfileCookieEncoder();

            Assert.Throws<InvalidOperationException>(() => encoder.GetDeviceCapabilities(cookie));
        }


    }
}
