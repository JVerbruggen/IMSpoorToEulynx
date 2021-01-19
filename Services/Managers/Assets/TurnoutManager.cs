using Models.TopoModels.EULYNX.sig;
using Models.TopoModels.IMSpoor.V1_3_0;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Assets
{
    public class TurnoutManager : ItemManager<Turnout>
    {
        public Turnout GetTurnout(tJunction junction)
        {
            Turnout turnout = null;

            if(junction is SingleSwitch)
            {
                var crossing = new Models.TopoModels.EULYNX.sig.Crossing();
                crossing.isOfCrossingType = CrossingTypes.simple;
            }
            else if(junction is DoubleDiamondCrossing)
            {
                var crossing = new Models.TopoModels.EULYNX.sig.Crossing();
                crossing.isOfCrossingType = CrossingTypes.doubleSlip;
            }
            else if(junction is SingleDiamondCrossing)
            {
                var crossing = new Models.TopoModels.EULYNX.sig.Crossing();
                crossing.isOfCrossingType = CrossingTypes.singleSlip;
            }
            else if(junction is Models.TopoModels.IMSpoor.V1_3_0.Crossing)
            {

            }
            else if(junction is Models.TopoModels.IMSpoor.V1_3_0.BufferStop)
            {

            }
            else if(junction is TerraIncognita)
            {

            }
            else if(junction is TrackEnd)
            {

            }

            return turnout;
        }

    }
}
