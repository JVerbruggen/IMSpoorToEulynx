using Models.TopoModels.EULYNX.dp;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Version = Models.TopoModels.EULYNX.dp.Version;

namespace Services.Managers.Toplevel
{
    public class VersionManager : AbstractManager<Version>
    {
        public Version GetVersion(IMSpoor imSpoor)
        {
            Version version = new Version();

            XsdGeneratorVersion xsdGeneratorVersion = new XsdGeneratorVersion();
            xsdGeneratorVersion.generatedByTool = "IMSpoor-1.2.3 to EULYNX Converter tool";
            xsdGeneratorVersion.generatedByToolVersion = "0.1";
            List<XsdGeneratorVersion> generatedByTool = new List<XsdGeneratorVersion> { xsdGeneratorVersion };

            Baseline baseline = new Baseline();
            baseline.major = 0;
            baseline.minor = 1;
            List<Baseline> hasBaseline = new List<Baseline> { baseline };

            version.generatedByTool = generatedByTool;
            version.hasBaseline = hasBaseline;

            return version;
        }
    }
}
