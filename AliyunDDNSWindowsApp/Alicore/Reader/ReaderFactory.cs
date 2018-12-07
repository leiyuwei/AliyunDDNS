﻿/*
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

using AliyunDDNSWindowsApp.Alicore.Http;

namespace AliyunDDNSWindowsApp.Alicore.Reader
{
    public class ReaderFactory
    {
        public static IReader CreateInstance(FormatType? format)
        {
            if (FormatType.JSON == format)
                return new JsonReader();
            if (FormatType.XML == format)
                return new XmlReader();

            return null;
        }
    }
}
