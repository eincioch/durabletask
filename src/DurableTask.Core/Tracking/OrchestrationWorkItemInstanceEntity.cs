//  ----------------------------------------------------------------------------------
//  Copyright Microsoft Corporation
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

namespace DurableTask.Core.Tracking
{
    using System;
    using DurableTask.Core.History;

    /// <summary>
    /// History Entity for a Work Item Instance
    /// </summary>
    public class OrchestrationWorkItemInstanceEntity : InstanceEntityBase
    {
        /// <summary>
        /// The orchestration instance id
        /// </summary>
        public string InstanceId;

        /// <summary>
        /// The orchestration execution id
        /// </summary>
        public string ExecutionId;

        /// <summary>
        /// Timestamp of the instance event
        /// </summary>
        public DateTime EventTimestamp;

        /// <summary>
        /// History event corresponding to this work item instance entity
        /// </summary>
        public HistoryEvent HistoryEvent;
    }
}
