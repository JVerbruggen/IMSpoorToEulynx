﻿using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor.V1_3_0;
using System;
using System.Collections.Generic;
using System.Text;
using Version = Models.TopoModels.Eulynx.Version;

namespace Services.Managers.Toplevel
{
    public class VersionManager
    {
        public Version GetVersion(IMSpoor imSpoor)
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
