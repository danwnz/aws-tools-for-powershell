/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.Organizations;
using Amazon.Organizations.Model;

namespace Amazon.PowerShell.Cmdlets.ORG
{
    /// <summary>
    /// Lists the account creation requests that match the specified status that is currently
    /// being tracked for the organization.
    /// 
    ///  <note><para>
    /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
    /// value when calling a <code>List*</code> operation. These operations can occasionally
    /// return an empty set of results even when there are more results available. The <code>NextToken</code>
    /// response parameter value is <code>null</code><i>only</i> when there are no more results
    /// to display.
    /// </para></note><para>
    /// This operation can be called only from the organization's master account or by a member
    /// account that is a delegated administrator for an AWS service.
    /// </para><br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "ORGAccountCreationStatusList")]
    [OutputType("Amazon.Organizations.Model.CreateAccountStatus")]
    [AWSCmdlet("Calls the AWS Organizations ListCreateAccountStatus API operation.", Operation = new[] {"ListCreateAccountStatus"}, SelectReturnType = typeof(Amazon.Organizations.Model.ListCreateAccountStatusResponse))]
    [AWSCmdletOutput("Amazon.Organizations.Model.CreateAccountStatus or Amazon.Organizations.Model.ListCreateAccountStatusResponse",
        "This cmdlet returns a collection of Amazon.Organizations.Model.CreateAccountStatus objects.",
        "The service call response (type Amazon.Organizations.Model.ListCreateAccountStatusResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetORGAccountCreationStatusListCmdlet : AmazonOrganizationsClientCmdlet, IExecutor
    {
        
        #region Parameter State
        /// <summary>
        /// <para>
        /// <para>A list of one or more states that you want included in the response. If this parameter
        /// isn't present, all requests are included in the response.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        [Alias("States")]
        public System.String[] State { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The total number of results that you want included on each page of the response. If
        /// you do not include this parameter, it defaults to a value that is specific to the
        /// operation. If additional items exist beyond the maximum you specify, the <code>NextToken</code>
        /// response element is present and has a value (is not null). Include that value as the
        /// <code>NextToken</code> request parameter in the next call to the operation to get
        /// the next part of the results. Note that Organizations might return fewer results than
        /// the maximum even when there are more results available. You should check <code>NextToken</code>
        /// after every operation to ensure that you receive all of the results.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> In AWSPowerShell and AWSPowerShell.NetCore this parameter is used to limit the total number of items returned by the cmdlet.
        /// <br/>In AWS.Tools this parameter is simply passed to the service to specify how many items should be returned by each service call.
        /// <br/>Pipe the output of this cmdlet into Select-Object -First to terminate retrieving data pages early and control the number of items returned.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxItems","MaxResults")]
        public int? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>The parameter for receiving additional results if you receive a <code>NextToken</code>
        /// response in a previous request. A <code>NextToken</code> response indicates that more
        /// output is available. Set this parameter to the value of the previous call's <code>NextToken</code>
        /// response to indicate where the output should continue from.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> This parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-NextToken $null' for the first call and '-NextToken $AWSHistory.LastServiceResponse.NextToken' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'CreateAccountStatuses'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Organizations.Model.ListCreateAccountStatusResponse).
        /// Specifying the name of a property of type Amazon.Organizations.Model.ListCreateAccountStatusResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "CreateAccountStatuses";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the State parameter.
        /// The -PassThru parameter is deprecated, use -Select '^State' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^State' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter NoAutoIteration
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Organizations.Model.ListCreateAccountStatusResponse, GetORGAccountCreationStatusListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.State;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.MaxResult = this.MaxResult;
            #if !MODULAR
            if (ParameterWasBound(nameof(this.MaxResult)) && this.MaxResult.HasValue)
            {
                WriteWarning("AWSPowerShell and AWSPowerShell.NetCore use the MaxResult parameter to limit the total number of items returned by the cmdlet." +
                    " This behavior is obsolete and will be removed in a future version of these modules. Pipe the output of this cmdlet into Select-Object -First to terminate" +
                    " retrieving data pages early and control the number of items returned. AWS.Tools already implements the new behavior of simply passing MaxResult" +
                    " to the service to specify how many items should be returned by each service call.");
            }
            #endif
            context.NextToken = this.NextToken;
            if (this.State != null)
            {
                context.State = new List<System.String>(this.State);
            }
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        #if MODULAR
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            
            // create request and set iteration invariants
            var request = new Amazon.Organizations.Model.ListCreateAccountStatusRequest();
            
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = AutoIterationHelpers.ConvertEmitLimitToServiceTypeInt32(cmdletContext.MaxResult.Value);
            }
            if (cmdletContext.State != null)
            {
                request.States = cmdletContext.State;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.NextToken;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    
                    _nextToken = response.NextToken;
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                ProcessOutput(output);
                
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken));
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        #else
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            
            // create request and set iteration invariants
            var request = new Amazon.Organizations.Model.ListCreateAccountStatusRequest();
            if (cmdletContext.State != null)
            {
                request.States = cmdletContext.State;
            }
            
            // Initialize loop variants and commence piping
            System.String _nextToken = null;
            int? _emitLimit = null;
            int _retrievedSoFar = 0;
            if (AutoIterationHelpers.HasValue(cmdletContext.NextToken))
            {
                _nextToken = cmdletContext.NextToken;
            }
            if (cmdletContext.MaxResult.HasValue)
            {
                // The service has a maximum page size of 20. If the user has
                // asked for more items than page max, and there is no page size
                // configured, we rely on the service ignoring the set maximum
                // and giving us 20 items back. If a page size is set, that will
                // be used to configure the pagination.
                // We'll make further calls to satisfy the user's request.
                _emitLimit = cmdletContext.MaxResult;
            }
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                if (_emitLimit.HasValue)
                {
                    int correctPageSize = Math.Min(20, _emitLimit.Value);
                    request.MaxResults = AutoIterationHelpers.ConvertEmitLimitToInt32(correctPageSize);
                }
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    int _receivedThisCall = response.CreateAccountStatuses.Count;
                    
                    _nextToken = response.NextToken;
                    _retrievedSoFar += _receivedThisCall;
                    if (_emitLimit.HasValue)
                    {
                        _emitLimit -= _receivedThisCall;
                    }
                }
                catch (Exception e)
                {
                    if (_retrievedSoFar == 0 || !_emitLimit.HasValue)
                    {
                        output = new CmdletOutput { ErrorResponse = e };
                    }
                    else
                    {
                        break;
                    }
                }
                
                ProcessOutput(output);
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken) && (!_emitLimit.HasValue || _emitLimit.Value >= 1));
            
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        #endif
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Organizations.Model.ListCreateAccountStatusResponse CallAWSServiceOperation(IAmazonOrganizations client, Amazon.Organizations.Model.ListCreateAccountStatusRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Organizations", "ListCreateAccountStatus");
            try
            {
                #if DESKTOP
                return client.ListCreateAccountStatus(request);
                #elif CORECLR
                return client.ListCreateAccountStatusAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public int? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public List<System.String> State { get; set; }
            public System.Func<Amazon.Organizations.Model.ListCreateAccountStatusResponse, GetORGAccountCreationStatusListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.CreateAccountStatuses;
        }
        
    }
}
