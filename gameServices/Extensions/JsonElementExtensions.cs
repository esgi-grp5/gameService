﻿using System.Text.Json;

namespace gameServices.Extensions
{
    public static class JsonElementExtensions
    {
        public static T ToObject<T>(this JsonElement element)
        {
            var json = element.GetRawText();
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}

