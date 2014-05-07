﻿
namespace nuComponents.DataTypes.Shared.Picker
{
    using Newtonsoft.Json;

    public class PickerEditorOption
    {
        [JsonProperty("key")]
        public string Key { get; set; }
     
        // TODO: change to Label
        [JsonProperty("markup")]
        public string Markup { get; set; }
    }
}
