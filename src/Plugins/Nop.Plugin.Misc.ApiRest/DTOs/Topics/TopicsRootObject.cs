﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Nop.Plugin.Misc.ApiRest.DTO;

namespace Nop.Plugin.Misc.ApiRest.DTOs.Topics
{
    public class TopicsRootObject : ISerializableObject
    {
        public TopicsRootObject()
        {
            Topics = new List<TopicDto>();
        }

        [JsonProperty("topics")]
        public IList<TopicDto> Topics { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "topics";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(TopicDto);
        }
    }
}
