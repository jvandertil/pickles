﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="JsonStep.cs" company="PicklesDoc">
//  Copyright 2011 Jeffrey Cameron
//  Copyright 2012-present PicklesDoc team and community contributors
//
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace PicklesDoc.Pickles.DocumentationBuilders.Json
{
    public class JsonStep
    {
        public JsonKeyword Keyword { get; set; }

        public string NativeKeyword { get; set; }

        public string Name { get; set; }

        public JsonTable TableArgument { get; set; }

        public string DocStringArgument { get; set; }

        public List<JsonComment> StepComments { get; set; }

        public List<JsonComment> AfterLastStepComments { get; set; }
    }
}
