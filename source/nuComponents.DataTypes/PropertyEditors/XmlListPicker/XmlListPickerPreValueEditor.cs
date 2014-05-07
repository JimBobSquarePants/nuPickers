﻿namespace nuComponents.DataTypes.PropertyEditors.XmlListPicker
{
    using nuComponents.DataTypes.Interfaces;
    using Umbraco.Core.PropertyEditors;

    internal class XmlListPickerPreValueEditor : PreValueEditor, IPickerPreValueEditor
    {
        // get data
        [PreValueField("dataSource", "", "App_Plugins/nuComponents/DataTypes/Shared/XmlDataSource/XmlDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        // transform data
        [PreValueField("labelMacro", "Label Macro", "App_Plugins/nuComponents/DataTypes/Shared/LabelMacro/LabelMacroConfig.html", Description = "expects a string parameter named 'key'")]
        public string LabelMacro { get; set; }

        // present data
        [PreValueField("listPicker", "", "App_Plugins/nuComponents/DataTypes/Shared/ListPicker/ListPickerConfig.html", HideLabel = true)]
        public string ListPicker { get; set; }

        // wire up
        [PreValueField("apiController", "XmlListPickerApi", "App_Plugins/nuComponents/DataTypes/Shared/HiddenConstant/HiddenConstantConfig.html", HideLabel = true)]
        public string ApiController { get; set; }
    }
}
