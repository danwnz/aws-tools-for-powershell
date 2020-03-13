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
using Amazon.Personalize;
using Amazon.Personalize.Model;

namespace Amazon.PowerShell.Cmdlets.PERS
{
    /// <summary>
    /// Creates a batch inference job. The operation can handle up to 50 million records and
    /// the input file must be in JSON format. For more information, see <a>recommendations-batch</a>.
    /// </summary>
    [Cmdlet("New", "PERSBatchInferenceJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Personalize CreateBatchInferenceJob API operation.", Operation = new[] {"CreateBatchInferenceJob"}, SelectReturnType = typeof(Amazon.Personalize.Model.CreateBatchInferenceJobResponse))]
    [AWSCmdletOutput("System.String or Amazon.Personalize.Model.CreateBatchInferenceJobResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.Personalize.Model.CreateBatchInferenceJobResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewPERSBatchInferenceJobCmdlet : AmazonPersonalizeClientCmdlet, IExecutor
    {
        
        #region Parameter FilterArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the filter to apply to the batch inference job. For more information on
        /// using filters, see Using Filters with Amazon Personalize.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String FilterArn { get; set; }
        #endregion
        
        #region Parameter JobName
        /// <summary>
        /// <para>
        /// <para>The name of the batch inference job to create.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String JobName { get; set; }
        #endregion
        
        #region Parameter S3DataSource_KmsKeyArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the Amazon Key Management Service (KMS) key that
        /// Amazon Personalize uses to encrypt or decrypt the input and output files of a batch
        /// inference job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("JobInput_S3DataSource_KmsKeyArn")]
        public System.String S3DataSource_KmsKeyArn { get; set; }
        #endregion
        
        #region Parameter S3DataDestination_KmsKeyArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the Amazon Key Management Service (KMS) key that
        /// Amazon Personalize uses to encrypt or decrypt the input and output files of a batch
        /// inference job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("JobOutput_S3DataDestination_KmsKeyArn")]
        public System.String S3DataDestination_KmsKeyArn { get; set; }
        #endregion
        
        #region Parameter NumResult
        /// <summary>
        /// <para>
        /// <para>The number of recommendations to retreive.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("NumResults")]
        public System.Int32? NumResult { get; set; }
        #endregion
        
        #region Parameter S3DataSource_Path
        /// <summary>
        /// <para>
        /// <para>The file path of the Amazon S3 bucket.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("JobInput_S3DataSource_Path")]
        public System.String S3DataSource_Path { get; set; }
        #endregion
        
        #region Parameter S3DataDestination_Path
        /// <summary>
        /// <para>
        /// <para>The file path of the Amazon S3 bucket.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("JobOutput_S3DataDestination_Path")]
        public System.String S3DataDestination_Path { get; set; }
        #endregion
        
        #region Parameter RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the Amazon Identity and Access Management role that has permissions to
        /// read and write to your input and out Amazon S3 buckets respectively.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String RoleArn { get; set; }
        #endregion
        
        #region Parameter SolutionVersionArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the solution version that will be used to generate
        /// the batch inference recommendations.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String SolutionVersionArn { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'BatchInferenceJobArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Personalize.Model.CreateBatchInferenceJobResponse).
        /// Specifying the name of a property of type Amazon.Personalize.Model.CreateBatchInferenceJobResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "BatchInferenceJobArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the JobName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^JobName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^JobName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.JobName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-PERSBatchInferenceJob (CreateBatchInferenceJob)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Personalize.Model.CreateBatchInferenceJobResponse, NewPERSBatchInferenceJobCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.JobName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.FilterArn = this.FilterArn;
            context.S3DataSource_KmsKeyArn = this.S3DataSource_KmsKeyArn;
            context.S3DataSource_Path = this.S3DataSource_Path;
            #if MODULAR
            if (this.S3DataSource_Path == null && ParameterWasBound(nameof(this.S3DataSource_Path)))
            {
                WriteWarning("You are passing $null as a value for parameter S3DataSource_Path which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.JobName = this.JobName;
            #if MODULAR
            if (this.JobName == null && ParameterWasBound(nameof(this.JobName)))
            {
                WriteWarning("You are passing $null as a value for parameter JobName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.S3DataDestination_KmsKeyArn = this.S3DataDestination_KmsKeyArn;
            context.S3DataDestination_Path = this.S3DataDestination_Path;
            #if MODULAR
            if (this.S3DataDestination_Path == null && ParameterWasBound(nameof(this.S3DataDestination_Path)))
            {
                WriteWarning("You are passing $null as a value for parameter S3DataDestination_Path which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.NumResult = this.NumResult;
            context.RoleArn = this.RoleArn;
            #if MODULAR
            if (this.RoleArn == null && ParameterWasBound(nameof(this.RoleArn)))
            {
                WriteWarning("You are passing $null as a value for parameter RoleArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SolutionVersionArn = this.SolutionVersionArn;
            #if MODULAR
            if (this.SolutionVersionArn == null && ParameterWasBound(nameof(this.SolutionVersionArn)))
            {
                WriteWarning("You are passing $null as a value for parameter SolutionVersionArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.Personalize.Model.CreateBatchInferenceJobRequest();
            
            if (cmdletContext.FilterArn != null)
            {
                request.FilterArn = cmdletContext.FilterArn;
            }
            
             // populate JobInput
            var requestJobInputIsNull = true;
            request.JobInput = new Amazon.Personalize.Model.BatchInferenceJobInput();
            Amazon.Personalize.Model.S3DataConfig requestJobInput_jobInput_S3DataSource = null;
            
             // populate S3DataSource
            var requestJobInput_jobInput_S3DataSourceIsNull = true;
            requestJobInput_jobInput_S3DataSource = new Amazon.Personalize.Model.S3DataConfig();
            System.String requestJobInput_jobInput_S3DataSource_s3DataSource_KmsKeyArn = null;
            if (cmdletContext.S3DataSource_KmsKeyArn != null)
            {
                requestJobInput_jobInput_S3DataSource_s3DataSource_KmsKeyArn = cmdletContext.S3DataSource_KmsKeyArn;
            }
            if (requestJobInput_jobInput_S3DataSource_s3DataSource_KmsKeyArn != null)
            {
                requestJobInput_jobInput_S3DataSource.KmsKeyArn = requestJobInput_jobInput_S3DataSource_s3DataSource_KmsKeyArn;
                requestJobInput_jobInput_S3DataSourceIsNull = false;
            }
            System.String requestJobInput_jobInput_S3DataSource_s3DataSource_Path = null;
            if (cmdletContext.S3DataSource_Path != null)
            {
                requestJobInput_jobInput_S3DataSource_s3DataSource_Path = cmdletContext.S3DataSource_Path;
            }
            if (requestJobInput_jobInput_S3DataSource_s3DataSource_Path != null)
            {
                requestJobInput_jobInput_S3DataSource.Path = requestJobInput_jobInput_S3DataSource_s3DataSource_Path;
                requestJobInput_jobInput_S3DataSourceIsNull = false;
            }
             // determine if requestJobInput_jobInput_S3DataSource should be set to null
            if (requestJobInput_jobInput_S3DataSourceIsNull)
            {
                requestJobInput_jobInput_S3DataSource = null;
            }
            if (requestJobInput_jobInput_S3DataSource != null)
            {
                request.JobInput.S3DataSource = requestJobInput_jobInput_S3DataSource;
                requestJobInputIsNull = false;
            }
             // determine if request.JobInput should be set to null
            if (requestJobInputIsNull)
            {
                request.JobInput = null;
            }
            if (cmdletContext.JobName != null)
            {
                request.JobName = cmdletContext.JobName;
            }
            
             // populate JobOutput
            var requestJobOutputIsNull = true;
            request.JobOutput = new Amazon.Personalize.Model.BatchInferenceJobOutput();
            Amazon.Personalize.Model.S3DataConfig requestJobOutput_jobOutput_S3DataDestination = null;
            
             // populate S3DataDestination
            var requestJobOutput_jobOutput_S3DataDestinationIsNull = true;
            requestJobOutput_jobOutput_S3DataDestination = new Amazon.Personalize.Model.S3DataConfig();
            System.String requestJobOutput_jobOutput_S3DataDestination_s3DataDestination_KmsKeyArn = null;
            if (cmdletContext.S3DataDestination_KmsKeyArn != null)
            {
                requestJobOutput_jobOutput_S3DataDestination_s3DataDestination_KmsKeyArn = cmdletContext.S3DataDestination_KmsKeyArn;
            }
            if (requestJobOutput_jobOutput_S3DataDestination_s3DataDestination_KmsKeyArn != null)
            {
                requestJobOutput_jobOutput_S3DataDestination.KmsKeyArn = requestJobOutput_jobOutput_S3DataDestination_s3DataDestination_KmsKeyArn;
                requestJobOutput_jobOutput_S3DataDestinationIsNull = false;
            }
            System.String requestJobOutput_jobOutput_S3DataDestination_s3DataDestination_Path = null;
            if (cmdletContext.S3DataDestination_Path != null)
            {
                requestJobOutput_jobOutput_S3DataDestination_s3DataDestination_Path = cmdletContext.S3DataDestination_Path;
            }
            if (requestJobOutput_jobOutput_S3DataDestination_s3DataDestination_Path != null)
            {
                requestJobOutput_jobOutput_S3DataDestination.Path = requestJobOutput_jobOutput_S3DataDestination_s3DataDestination_Path;
                requestJobOutput_jobOutput_S3DataDestinationIsNull = false;
            }
             // determine if requestJobOutput_jobOutput_S3DataDestination should be set to null
            if (requestJobOutput_jobOutput_S3DataDestinationIsNull)
            {
                requestJobOutput_jobOutput_S3DataDestination = null;
            }
            if (requestJobOutput_jobOutput_S3DataDestination != null)
            {
                request.JobOutput.S3DataDestination = requestJobOutput_jobOutput_S3DataDestination;
                requestJobOutputIsNull = false;
            }
             // determine if request.JobOutput should be set to null
            if (requestJobOutputIsNull)
            {
                request.JobOutput = null;
            }
            if (cmdletContext.NumResult != null)
            {
                request.NumResults = cmdletContext.NumResult.Value;
            }
            if (cmdletContext.RoleArn != null)
            {
                request.RoleArn = cmdletContext.RoleArn;
            }
            if (cmdletContext.SolutionVersionArn != null)
            {
                request.SolutionVersionArn = cmdletContext.SolutionVersionArn;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Personalize.Model.CreateBatchInferenceJobResponse CallAWSServiceOperation(IAmazonPersonalize client, Amazon.Personalize.Model.CreateBatchInferenceJobRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Personalize", "CreateBatchInferenceJob");
            try
            {
                #if DESKTOP
                return client.CreateBatchInferenceJob(request);
                #elif CORECLR
                return client.CreateBatchInferenceJobAsync(request).GetAwaiter().GetResult();
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
            public System.String FilterArn { get; set; }
            public System.String S3DataSource_KmsKeyArn { get; set; }
            public System.String S3DataSource_Path { get; set; }
            public System.String JobName { get; set; }
            public System.String S3DataDestination_KmsKeyArn { get; set; }
            public System.String S3DataDestination_Path { get; set; }
            public System.Int32? NumResult { get; set; }
            public System.String RoleArn { get; set; }
            public System.String SolutionVersionArn { get; set; }
            public System.Func<Amazon.Personalize.Model.CreateBatchInferenceJobResponse, NewPERSBatchInferenceJobCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.BatchInferenceJobArn;
        }
        
    }
}
