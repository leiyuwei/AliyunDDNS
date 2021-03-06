/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

using AliyunDDNSWindowsApp.Alicore;
using AliyunDDNSWindowsApp.Alicore.Transform;
using AliyunDDNSWindowsApp.Alicore.Utils;
using AliyunDDNSWindowsApp.Alidns.Transform.V20150109;

namespace AliyunDDNSWindowsApp.Alidns.Model.V20150109
{
    public class DescribeDomainLogsRequest : RpcAcsRequest<DescribeDomainLogsResponse>
    {
        public DescribeDomainLogsRequest()
            : base("Alidns", "2015-01-09", "DescribeDomainLogs")
        {
        }

		private string lang;

		private string userClientIp;

		private string keyWord;

		private string groupId;

		private long? pageNumber;

		private long? pageSize;

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string KeyWord
		{
			get
			{
				return keyWord;
			}
			set	
			{
				keyWord = value;
				DictionaryUtil.Add(QueryParameters, "KeyWord", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

        public override DescribeDomainLogsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDomainLogsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}