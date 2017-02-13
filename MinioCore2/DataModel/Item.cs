﻿/*
 * Minio .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2017 Minio, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace MinioCore2.DataModel
{
    [Serializable]
    public class Item
    {
        private string etag;

        public string Key { get; set; }
        public string LastModified { get; set; }
        public string ETag
        {
            get
            {
                return etag;
            }
            set
            {
                if (value != null)
                {
                    etag = value.Replace("\"", "");
                }
                else
                {
                    etag = null;
                }
            }
        }
        public UInt64 Size { get; set; }

        public bool IsDir { get; set; }

        public DateTime LastModifiedDateTime
        {
            get
            {
                return DateTime.Parse(this.LastModified);
            }
        }
    }
}
