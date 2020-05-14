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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetMfaFlagRequest : AbstractModel
    {
        
        /// <summary>
        /// 设置用户的uin
        /// </summary>
        [JsonProperty("OpUin")]
        public ulong? OpUin{ get; set; }

        /// <summary>
        /// 登录保护设置
        /// </summary>
        [JsonProperty("LoginFlag")]
        public LoginActionMfaFlag LoginFlag{ get; set; }

        /// <summary>
        /// 操作保护设置
        /// </summary>
        [JsonProperty("ActionFlag")]
        public LoginActionMfaFlag ActionFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpUin", this.OpUin);
            this.SetParamObj(map, prefix + "LoginFlag.", this.LoginFlag);
            this.SetParamObj(map, prefix + "ActionFlag.", this.ActionFlag);
        }
    }
}

