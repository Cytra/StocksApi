using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;

namespace Stocks.Model.Converters
{
    public class ShortDateConverter : JsonConverter
    {
        private const string DateTimeFormat = "yyyy-MM-dd";


        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            return DateTime.ParseExact((string)reader.Value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime time)
            {
                writer.WriteValue(time.ToString(DateTimeFormat));
            }
            else
            {
                throw new InvalidCastException("A date was expected but not received.");
            }
        }
    }
}
