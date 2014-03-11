// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Details of a specific role instance.
    /// </summary>
    public partial class RoleInstance
    {
        private string _hostName;
        
        /// <summary>
        /// The DNS host name of the service in which the role instance is
        /// running. This element is only listed for Virtual Machine
        /// deployments.
        /// </summary>
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }
        
        private IList<InstanceEndpoint> _instanceEndpoints;
        
        /// <summary>
        /// The list of instance endpoints for the role.
        /// </summary>
        public IList<InstanceEndpoint> InstanceEndpoints
        {
            get { return this._instanceEndpoints; }
            set { this._instanceEndpoints = value; }
        }
        
        private string _instanceErrorCode;
        
        /// <summary>
        /// An error code that can be provided to WindowsAzure support to
        /// assist in resolution of errors. Typicallythis field will be empty.
        /// </summary>
        public string InstanceErrorCode
        {
            get { return this._instanceErrorCode; }
            set { this._instanceErrorCode = value; }
        }
        
        private int? _instanceFaultDomain;
        
        /// <summary>
        /// The fault domain that this role instance belongs to. Role instances
        /// that are part of the same fault domain may all be vulnerable to
        /// the failure of the same piece of shared hardware.
        /// </summary>
        public int? InstanceFaultDomain
        {
            get { return this._instanceFaultDomain; }
            set { this._instanceFaultDomain = value; }
        }
        
        private string _instanceName;
        
        /// <summary>
        /// TThe name of the specific role instance, if an instance of the role
        /// is running.
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }
        
        private string _instanceSize;
        
        /// <summary>
        /// The size of the role instance.
        /// </summary>
        public string InstanceSize
        {
            get { return this._instanceSize; }
            set { this._instanceSize = value; }
        }
        
        private string _instanceStateDetails;
        
        /// <summary>
        /// The instance state is returned as a string that, when present,
        /// provides a snapshot of the state of the virtual machine at the
        /// time the operation was called.
        /// </summary>
        public string InstanceStateDetails
        {
            get { return this._instanceStateDetails; }
            set { this._instanceStateDetails = value; }
        }
        
        private string _instanceStatus;
        
        /// <summary>
        /// The current status of this instance.
        /// </summary>
        public string InstanceStatus
        {
            get { return this._instanceStatus; }
            set { this._instanceStatus = value; }
        }
        
        private int? _instanceUpgradeDomain;
        
        /// <summary>
        /// The update domain that this role instance belongs to. During an
        /// Upgrade Deployment, all roles in the same update domain are
        /// updated at the same time.
        /// </summary>
        public int? InstanceUpgradeDomain
        {
            get { return this._instanceUpgradeDomain; }
            set { this._instanceUpgradeDomain = value; }
        }
        
        private string _iPAddress;
        
        /// <summary>
        /// The IP address of the role instance (DIP).
        /// </summary>
        public string IPAddress
        {
            get { return this._iPAddress; }
            set { this._iPAddress = value; }
        }
        
        private RoleInstancePowerState _powerState;
        
        /// <summary>
        /// The running state of the role instance.
        /// </summary>
        public RoleInstancePowerState PowerState
        {
            get { return this._powerState; }
            set { this._powerState = value; }
        }
        
        private string _remoteAccessCertificateThumbprint;
        
        /// <summary>
        /// The thumbprint of the RDP server certificate (in Windows) or SSH
        /// server certificate (in Linux). The thumbprint is only used for
        /// Virtual Machines that have been created from an image.
        /// </summary>
        public string RemoteAccessCertificateThumbprint
        {
            get { return this._remoteAccessCertificateThumbprint; }
            set { this._remoteAccessCertificateThumbprint = value; }
        }
        
        private string _roleName;
        
        /// <summary>
        /// The name of the role.
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RoleInstance class.
        /// </summary>
        public RoleInstance()
        {
            this._instanceEndpoints = new List<InstanceEndpoint>();
        }
    }
}
