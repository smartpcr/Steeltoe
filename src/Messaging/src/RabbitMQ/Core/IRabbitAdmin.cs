﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Steeltoe.Common.Services;
using Steeltoe.Messaging.Rabbit.Config;
using System.Collections.Generic;

namespace Steeltoe.Messaging.Rabbit.Core
{
    public interface IRabbitAdmin : IServiceNameAware
    {
        void DeclareExchange(IExchange exchange);

        bool DeleteExchange(string exchangeName);

        IQueue DeclareQueue();

        string DeclareQueue(IQueue queue);

        bool DeleteQueue(string queueName);

        void DeleteQueue(string queueName, bool unused, bool empty);

        void PurgeQueue(string queueName, bool noWait);

        uint PurgeQueue(string queueName);

        void DeclareBinding(IBinding binding);

        void RemoveBinding(IBinding binding);

        Dictionary<string, object> GetQueueProperties(string queueName);

        QueueInformation GetQueueInfo(string queueName);

        void Initialize();
    }
}