﻿/*  
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

(function (mstats) {
    mstats.expander = function (require) {
        
        var $ = require('$');
        
        var selector = 'dl.widget';
        
        function attach(view) {
            var widget = view.find(selector);

            widget.addClass('closed');
            
            widget.children('dt').click(function (e) {
				e.preventDefault();
				$(this).parent(selector).toggleClass('closed');
			});
        }

        return {
            attach: attach
        };
    };
} (this.mstats = this.mstats || {}));