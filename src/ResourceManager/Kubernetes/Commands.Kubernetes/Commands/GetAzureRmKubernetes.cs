// ----------------------------------------------------------------------------------
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Kubernetes.Generated;
using Microsoft.Azure.Commands.Kubernetes.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Internal.Resources.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.Kubernetes
{
    [Cmdlet(VerbsCommon.Get, KubeNounStr)]
    [OutputType(typeof(PSKubernetesCluster), typeof(List<PSKubernetesCluster>))]
    public class Get : KubeCmdletBase
    {
        private const string ResourceGroupParameterSet = "ResourceGroupParameterSet";
        private const string NameParameterSet = "NameParameterSet";
        private const string IdParameterSet = "IdParameterSet";

        /// <summary>
        /// Cluster name
        /// </summary>
        [Parameter(Mandatory = true,
            ParameterSetName = IdParameterSet,
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Id of a managed Kubernetes cluster")]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [Parameter(Mandatory = true,
            ParameterSetName = NameParameterSet,
            Position = 1,
            HelpMessage = "Name of your managed Kubernetes cluster")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
            Position = 0,
            Mandatory = false,
            ParameterSetName = ResourceGroupParameterSet,
            HelpMessage = "Resource group name")]
        [Parameter(
            Position = 0,
            Mandatory = true,
            ParameterSetName = NameParameterSet,
            HelpMessage = "Resource group name")]
        [ResourceGroupCompleter()]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            RunCmdLet(() =>
            {
                switch (ParameterSetName)
                {
                    case NameParameterSet:
                        var kubeCluster = Client.ManagedClusters.Get(ResourceGroupName, Name);
                        WriteObject(PSMapper.Instance.Map<PSKubernetesCluster>(kubeCluster));
                        break;
                    case IdParameterSet:
                        var resource = new ResourceIdentifier(Id);
                        var idCluster = Client.ManagedClusters.Get(resource.ResourceGroupName, resource.ResourceName);
                        WriteObject(PSMapper.Instance.Map<PSKubernetesCluster>(idCluster));
                        break;
                    case ResourceGroupParameterSet:
                        var kubeClusters = string.IsNullOrEmpty(ResourceGroupName)
                            ? Client.ManagedClusters.List()
                            : Client.ManagedClusters.ListByResourceGroup(ResourceGroupName);
                        WriteObject(kubeClusters.Select(PSMapper.Instance.Map<PSKubernetesCluster>));
                        break;
                    default:
                        throw new ArgumentException("Bad parameterset name. This is a bug and should be reported.");
                }
            });
        }
    }
}