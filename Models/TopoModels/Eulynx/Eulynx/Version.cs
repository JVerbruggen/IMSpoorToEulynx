using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Version
    {
        public static Version GetVersion(String versionString)
        {
            Version version = new Version();

            XsdGeneratorVersion xsdGeneratorVersion = new XsdGeneratorVersion();
            xsdGeneratorVersion.generatedByTool = "IMSpoor-1.3.0 to EULYNX Converter tool";
            xsdGeneratorVersion.generatedByToolVersion = "0.1";
            XsdGeneratorVersion[] generatedByTool = new XsdGeneratorVersion[] { xsdGeneratorVersion };

            Baseline baseline = new Baseline();
            baseline.major = 0;
            baseline.minor = 1;
            Baseline[] hasBaseline = new Baseline[] { baseline };

            version.generatedByTool = generatedByTool;
            version.hasBaseline = hasBaseline;

            return version;
        }

    }
}
