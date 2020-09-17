using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Version : ITranslatableSingle<Version, IMSpoor.IMSpoor>
    {
        public Version TranslateSingle(IMSpoor.IMSpoor imSpoor)
        {
            XsdGeneratorVersion xsdGeneratorVersion = new XsdGeneratorVersion();
            xsdGeneratorVersion.generatedByTool = "IMSpoor-1.3.0 to EULYNX Converter tool";
            xsdGeneratorVersion.generatedByToolVersion = "0.1";
            XsdGeneratorVersion[] generatedByTool = new XsdGeneratorVersion[] { xsdGeneratorVersion };

            Baseline baseline = new Baseline();
            baseline.major = 0;
            baseline.minor = 1;
            Baseline[] hasBaseline = new Baseline[] { baseline };

            this.generatedByTool = generatedByTool;
            this.hasBaseline = hasBaseline;

            return this;
        }
    }
}
