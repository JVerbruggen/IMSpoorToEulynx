using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.dp
{
    public partial class CablingTopology
    {

        [Obsolete("Change to Topology")]
        public static CablingTopology GetCablingTopology()
        {
            CablingTopology cablingTopology = new CablingTopology();

            return cablingTopology;
        }

    }
}
