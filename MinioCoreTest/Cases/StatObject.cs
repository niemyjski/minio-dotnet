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
using System.Threading.Tasks;
using MinioCore2.DataModel;

namespace MinioCoreTest.Cases
{
    class StatObject
    {
        //get stats on a object
        public async static Task Run(MinioCore2.MinioClient minio, 
                                     string bucketName = "my-bucket-name",
                                     string bucketObject="my-object-name")
        {
            try
            {
                ObjectStat statObject = await minio.StatObjectAsync(bucketName, bucketObject);
                Console.Out.WriteLine(statObject);
            }
            catch (Exception e)
            {
                Console.WriteLine("[StatObject] {0}-{1}  Exception: {2}",bucketName, bucketObject, e);
            }
        }
    }
}
