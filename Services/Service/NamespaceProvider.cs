using Models.Translation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{

    public class NamespaceProvider : IService
    {
        public static Dictionary<string, string> GetEulynxNamespaces()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("xsi", @"http://www.w3.org/2001/XMLSchema-instance");
            dict.Add("rtmCommon", @"http://www.railtopomodel.org/schemas/Common");
            dict.Add("rtmNE", @"http://www.railtopomodel.org/schemas/NetEntity");
            dict.Add("rtmSig", @"http://www.railtopomodel.org/schemas/Signalling");
            dict.Add("base", @"http://www.railtopomodel.org/schemas/EULYNX_XSD");
            dict.Add("eurtm", @"http://www.railtopomodel.org/schemas/EULYNX_XSD");
            dict.Add("signalling", @"http://www.railtopomodel.org/schemas/EULYNX_Signalling");

            return dict;
        }

        public static Dictionary<string, string> GetIMSpoorNamespaces()
        {
            var dict = new Dictionary<string, string>();
            dict.Add(String.Empty, @"http://www.prorail.nl/IMSpoor");
            dict.Add("xsi", @"http://www.w3.org/2001/XMLSchema-instance");
            dict.Add("gml", @"http://www.opengis.net/gml");
            dict.Add("xs", @"http://www.w3.org/2001/XMLSchema");

            return dict;
        }

    }
}
