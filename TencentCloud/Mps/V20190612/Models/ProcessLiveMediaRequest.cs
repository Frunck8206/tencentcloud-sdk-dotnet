/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessLiveMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// 直播流 URL。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 直播流处理输出文件的目标存储。如处理有文件输出，该参数为必填项。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 直播流处理生成的文件输出的目标目录，如`/movie/201909/`，如果不填为 `/` 目录。
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// 直播流内容识别类型任务参数。
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// 直播流内容分析类型任务参数。
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// 任务的事件通知信息，不填代表不获取事件通知。
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public TaskNotifyConfig TaskNotifyConfig{ get; set; }

        /// <summary>
        /// 来源上下文，用于透传用户请求信息，任务流状态变更回调将返回该字段值，最长 1000 个字符。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 用于去重的识别码，如果七天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 直播开始时间戳（UTC 时间 单位为秒，该参数仅对于直播流分析有效）。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

