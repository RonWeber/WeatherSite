using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BusinessLogic
{
    public class NWSResponse : WeatherResponse
    {
        public NWSResponse() { }
        public dwml xml;

        public override string getHTML()
        {
            string table = "<b>" + xml.data.location.ToString() + "</b><br/>";
            return table;
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class dwml
        {

            private dwmlHead headField;

            private dwmlData dataField;

            private decimal versionField;

            /// <remarks/>
            public dwmlHead head
            {
                get
                {
                    return this.headField;
                }
                set
                {
                    this.headField = value;
                }
            }

            /// <remarks/>
            public dwmlData data
            {
                get
                {
                    return this.dataField;
                }
                set
                {
                    this.dataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlHead
        {

            private dwmlHeadProduct productField;

            private dwmlHeadSource sourceField;

            /// <remarks/>
            public dwmlHeadProduct product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            public dwmlHeadSource source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlHeadProduct
        {

            private string titleField;

            private string fieldField;

            private string categoryField;

            private dwmlHeadProductCreationdate creationdateField;

            private string srsNameField;

            private string concisenameField;

            private string operationalmodeField;

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string field
            {
                get
                {
                    return this.fieldField;
                }
                set
                {
                    this.fieldField = value;
                }
            }

            /// <remarks/>
            public string category
            {
                get
                {
                    return this.categoryField;
                }
                set
                {
                    this.categoryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("creation-date")]
            public dwmlHeadProductCreationdate creationdate
            {
                get
                {
                    return this.creationdateField;
                }
                set
                {
                    this.creationdateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string srsName
            {
                get
                {
                    return this.srsNameField;
                }
                set
                {
                    this.srsNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("concise-name")]
            public string concisename
            {
                get
                {
                    return this.concisenameField;
                }
                set
                {
                    this.concisenameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("operational-mode")]
            public string operationalmode
            {
                get
                {
                    return this.operationalmodeField;
                }
                set
                {
                    this.operationalmodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlHeadProductCreationdate
        {

            private string refreshfrequencyField;

            private System.DateTime valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("refresh-frequency", DataType = "duration")]
            public string refreshfrequency
            {
                get
                {
                    return this.refreshfrequencyField;
                }
                set
                {
                    this.refreshfrequencyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public System.DateTime Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlHeadSource
        {

            private string moreinformationField;

            private dwmlHeadSourceProductioncenter productioncenterField;

            private string disclaimerField;

            private string creditField;

            private string creditlogoField;

            private string feedbackField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("more-information")]
            public string moreinformation
            {
                get
                {
                    return this.moreinformationField;
                }
                set
                {
                    this.moreinformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("production-center")]
            public dwmlHeadSourceProductioncenter productioncenter
            {
                get
                {
                    return this.productioncenterField;
                }
                set
                {
                    this.productioncenterField = value;
                }
            }

            /// <remarks/>
            public string disclaimer
            {
                get
                {
                    return this.disclaimerField;
                }
                set
                {
                    this.disclaimerField = value;
                }
            }

            /// <remarks/>
            public string credit
            {
                get
                {
                    return this.creditField;
                }
                set
                {
                    this.creditField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("credit-logo")]
            public string creditlogo
            {
                get
                {
                    return this.creditlogoField;
                }
                set
                {
                    this.creditlogoField = value;
                }
            }

            /// <remarks/>
            public string feedback
            {
                get
                {
                    return this.feedbackField;
                }
                set
                {
                    this.feedbackField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlHeadSourceProductioncenter
        {

            private string subcenterField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("sub-center")]
            public string subcenter
            {
                get
                {
                    return this.subcenterField;
                }
                set
                {
                    this.subcenterField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlData
        {

            private dwmlDataLocation locationField;

            private dwmlDataMoreWeatherInformation moreWeatherInformationField;

            private dwmlDataTimelayout[] timelayoutField;

            private dwmlDataParameters parametersField;

            /// <remarks/>
            public dwmlDataLocation location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public dwmlDataMoreWeatherInformation moreWeatherInformation
            {
                get
                {
                    return this.moreWeatherInformationField;
                }
                set
                {
                    this.moreWeatherInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("time-layout")]
            public dwmlDataTimelayout[] timelayout
            {
                get
                {
                    return this.timelayoutField;
                }
                set
                {
                    this.timelayoutField = value;
                }
            }

            /// <remarks/>
            public dwmlDataParameters parameters
            {
                get
                {
                    return this.parametersField;
                }
                set
                {
                    this.parametersField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataLocation
        {

            private string locationkeyField;

            private dwmlDataLocationPoint pointField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("location-key")]
            public string locationkey
            {
                get
                {
                    return this.locationkeyField;
                }
                set
                {
                    this.locationkeyField = value;
                }
            }

            /// <remarks/>
            public dwmlDataLocationPoint point
            {
                get
                {
                    return this.pointField;
                }
                set
                {
                    this.pointField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataLocationPoint
        {

            private decimal latitudeField;

            private decimal longitudeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal latitude
            {
                get
                {
                    return this.latitudeField;
                }
                set
                {
                    this.latitudeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal longitude
            {
                get
                {
                    return this.longitudeField;
                }
                set
                {
                    this.longitudeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataMoreWeatherInformation
        {

            private string applicablelocationField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("applicable-location")]
            public string applicablelocation
            {
                get
                {
                    return this.applicablelocationField;
                }
                set
                {
                    this.applicablelocationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataTimelayout
        {

            private object[] itemsField;

            private ItemsChoiceType[] itemsElementNameField;

            private string timecoordinateField;

            private string summarizationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("end-valid-time", typeof(System.DateTime))]
            [System.Xml.Serialization.XmlElementAttribute("layout-key", typeof(string))]
            [System.Xml.Serialization.XmlElementAttribute("start-valid-time", typeof(System.DateTime))]
            [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public ItemsChoiceType[] ItemsElementName
            {
                get
                {
                    return this.itemsElementNameField;
                }
                set
                {
                    this.itemsElementNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("time-coordinate")]
            public string timecoordinate
            {
                get
                {
                    return this.timecoordinateField;
                }
                set
                {
                    this.timecoordinateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string summarization
            {
                get
                {
                    return this.summarizationField;
                }
                set
                {
                    this.summarizationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
        public enum ItemsChoiceType
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("end-valid-time")]
            endvalidtime,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("layout-key")]
            layoutkey,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("start-valid-time")]
            startvalidtime,
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataParameters
        {

            private dwmlDataParametersTemperature[] temperatureField;

            private dwmlDataParametersProbabilityofprecipitation probabilityofprecipitationField;

            private dwmlDataParametersWeather weatherField;

            private dwmlDataParametersConditionsicon conditionsiconField;

            private dwmlDataParametersHazards hazardsField;

            private string applicablelocationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("temperature")]
            public dwmlDataParametersTemperature[] temperature
            {
                get
                {
                    return this.temperatureField;
                }
                set
                {
                    this.temperatureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("probability-of-precipitation")]
            public dwmlDataParametersProbabilityofprecipitation probabilityofprecipitation
            {
                get
                {
                    return this.probabilityofprecipitationField;
                }
                set
                {
                    this.probabilityofprecipitationField = value;
                }
            }

            /// <remarks/>
            public dwmlDataParametersWeather weather
            {
                get
                {
                    return this.weatherField;
                }
                set
                {
                    this.weatherField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("conditions-icon")]
            public dwmlDataParametersConditionsicon conditionsicon
            {
                get
                {
                    return this.conditionsiconField;
                }
                set
                {
                    this.conditionsiconField = value;
                }
            }

            /// <remarks/>
            public dwmlDataParametersHazards hazards
            {
                get
                {
                    return this.hazardsField;
                }
                set
                {
                    this.hazardsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("applicable-location")]
            public string applicablelocation
            {
                get
                {
                    return this.applicablelocationField;
                }
                set
                {
                    this.applicablelocationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataParametersTemperature
        {

            private string nameField;

            private string[] valueField;

            private string typeField;

            private string unitsField;

            private string timelayoutField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("value", IsNullable = true)]
            public string[] value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string units
            {
                get
                {
                    return this.unitsField;
                }
                set
                {
                    this.unitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("time-layout")]
            public string timelayout
            {
                get
                {
                    return this.timelayoutField;
                }
                set
                {
                    this.timelayoutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataParametersProbabilityofprecipitation
        {

            private string nameField;

            private string[] valueField;

            private string typeField;

            private string unitsField;

            private string timelayoutField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("value", IsNullable = true)]
            public string[] value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string units
            {
                get
                {
                    return this.unitsField;
                }
                set
                {
                    this.unitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("time-layout")]
            public string timelayout
            {
                get
                {
                    return this.timelayoutField;
                }
                set
                {
                    this.timelayoutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataParametersWeather
        {

            private string nameField;

            private dwmlDataParametersWeatherWeatherconditions[] weatherconditionsField;

            private string timelayoutField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("weather-conditions")]
            public dwmlDataParametersWeatherWeatherconditions[] weatherconditions
            {
                get
                {
                    return this.weatherconditionsField;
                }
                set
                {
                    this.weatherconditionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("time-layout")]
            public string timelayout
            {
                get
                {
                    return this.timelayoutField;
                }
                set
                {
                    this.timelayoutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataParametersWeatherWeatherconditions
        {

            private dwmlDataParametersWeatherWeatherconditionsValue[] valueField;

            private string weathersummaryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("value")]
            public dwmlDataParametersWeatherWeatherconditionsValue[] value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("weather-summary")]
            public string weathersummary
            {
                get
                {
                    return this.weathersummaryField;
                }
                set
                {
                    this.weathersummaryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataParametersWeatherWeatherconditionsValue
        {

            private string coverageField;

            private string intensityField;

            private string weathertypeField;

            private string qualifierField;

            private string additiveField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string coverage
            {
                get
                {
                    return this.coverageField;
                }
                set
                {
                    this.coverageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string intensity
            {
                get
                {
                    return this.intensityField;
                }
                set
                {
                    this.intensityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("weather-type")]
            public string weathertype
            {
                get
                {
                    return this.weathertypeField;
                }
                set
                {
                    this.weathertypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string qualifier
            {
                get
                {
                    return this.qualifierField;
                }
                set
                {
                    this.qualifierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string additive
            {
                get
                {
                    return this.additiveField;
                }
                set
                {
                    this.additiveField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataParametersConditionsicon
        {

            private string nameField;

            private string[] iconlinkField;

            private string typeField;

            private string timelayoutField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("icon-link")]
            public string[] iconlink
            {
                get
                {
                    return this.iconlinkField;
                }
                set
                {
                    this.iconlinkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("time-layout")]
            public string timelayout
            {
                get
                {
                    return this.timelayoutField;
                }
                set
                {
                    this.timelayoutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class dwmlDataParametersHazards
        {

            private string nameField;

            private object hazardconditionsField;

            private string timelayoutField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("hazard-conditions", IsNullable = true)]
            public object hazardconditions
            {
                get
                {
                    return this.hazardconditionsField;
                }
                set
                {
                    this.hazardconditionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("time-layout")]
            public string timelayout
            {
                get
                {
                    return this.timelayoutField;
                }
                set
                {
                    this.timelayoutField = value;
                }
            }
        }

    }

}
