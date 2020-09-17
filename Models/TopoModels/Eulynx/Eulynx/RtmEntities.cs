using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class RtmEntities : ITranslatableSingle<RtmEntities, tSituation>
    {
        public RtmEntities TranslateSingle(tSituation situation)
        {
            //this.ownsBufferstop = VehicleStop.GetVehicleStops();
            //this.ownsPoint = Turnout.GetTurnouts();
            //this.ownsRouteBody = RouteBody.GetRouteBodies();
            //this.ownsSignal = Signal.GetSignals();
            //this.usesCablingTopology = CablingTopology.GetCablingTopology();
            //this.usesLinearLocation = LinearLocation.GetLinearLocations();
            //this.usesPositioningSystem = PositioningSystem.GetPositioningSystems();
            //this.usesPositioningSystemCoordinate = PositioningSystemCoordinate.GetPositioningSystemCoordinates();
            //this.usesSpotLocation = SpotLocation.GetSpotLocations();
            this.usesTrackTopology = new TrackTopology().TranslateSingle(situation.RailInfrastructure.RailTopology);
            this.uuid = "";

            return this;
        }
    }
}
