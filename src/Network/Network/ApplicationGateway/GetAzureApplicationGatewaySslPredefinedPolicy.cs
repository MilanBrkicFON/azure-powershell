﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network
{
    using AutoMapper;
    using Microsoft.Azure.Commands.Network.Models;
    using Microsoft.Azure.Management.Network;
    using System.Collections.Generic;
    using System.Management.Automation;

    [Cmdlet(VerbsCommon.Get, "AzApplicationGatewaySslPredefinedPolicy"), 
        OutputType(typeof(PSApplicationGatewaySslPredefinedPolicy), typeof(IEnumerable<PSApplicationGatewaySslPredefinedPolicy>))]
    [Alias("List-AzApplicationGatewaySslPredefinedPolicy")]
    public class GetAzureApplicationGatewaySslPredefinedPolicy : ApplicationGatewayBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            HelpMessage = "Name of the ssl predefined policy")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            if (this.Name != null)
            {
                var policy = this.ApplicationGatewayClient.GetSslPredefinedPolicy(this.Name);
                var psPolicy = NetworkResourceManagerProfile.Mapper.Map<PSApplicationGatewaySslPredefinedPolicy>(policy);
                WriteObject(psPolicy, true);
            }
            else
            {
                var policies = this.ApplicationGatewayClient.ListAvailableSslPredefinedPolicies();
                var psPolicies = new List<PSApplicationGatewaySslPredefinedPolicy>();
                foreach (var policy in policies)
                {
                    psPolicies.Add(NetworkResourceManagerProfile.Mapper.Map<PSApplicationGatewaySslPredefinedPolicy>(policy));
                }

                WriteObject(psPolicies, true);
            }
        }
    }
}

