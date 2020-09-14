using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class RtmEntities
    {

        public static RtmEntities GetRtmEntities()
        {
            RtmEntities rtmEntities = new RtmEntities();

            rtmEntities.ownsBufferstop = VehicleStop.GetVehicleStops();
            rtmEntities.ownsPoint = Turnout.GetTurnouts();
            rtmEntities.ownsRouteBody = RouteBody.GetRouteBodies();
            rtmEntities.ownsSignal = Signal.GetSignals();
            rtmEntities.usesCablingTopology = CablingTopology.GetCablingTopology();
            rtmEntities.usesLinearLocation = LinearLocation.GetLinearLocations();
            rtmEntities.usesPositioningSystem = PositioningSystem.GetPositioningSystems();
            rtmEntities.usesPositioningSystemCoordinate = PositioningSystemCoordinate.GetPositioningSystemCoordinates();
            rtmEntities.usesSpotLocation = SpotLocation.GetSpotLocations();
            rtmEntities.usesTrackTopology = TrackTopology.GetTrackTopology();
            rtmEntities.uuid = "";

            return rtmEntities;
        }

    }
}
