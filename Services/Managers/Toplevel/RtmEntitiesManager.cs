using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor.V1_3_0;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Managers.Location;
using Services.Managers.Positioning;
using Services.Managers.Topology;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Toplevel
{
    public class RtmEntitiesManager : UUIDObjectManager<RtmEntities>
    {
        public RtmEntities GetRtmEntities(tSituation situation)
        {
            RtmEntities rtmEntities = new RtmEntities();

            //this.ownsBufferstop = VehicleStop.GetVehicleStops();
            //this.ownsPoint = Turnout.GetTurnouts();
            //this.ownsRouteBody = RouteBody.GetRouteBodies();
            //this.ownsSignal = 
            //this.usesCablingTopology = CablingTopology.GetCablingTopology();
            //this.usesLinearLocation = LinearLocation.GetLinearLocations();
            rtmEntities.usesTrackTopology = InstanceManager.Singleton<TrackTopologyManager>().GetInstance().GetTrackTopology(situation.RailInfrastructure.RailTopology);
            rtmEntities.usesSpotLocation = InstanceManager.Singleton<SpotLocationManager>().GetInstance().GetAll();
            rtmEntities.usesPositioningSystem = InstanceManager.Singleton<PositioningSystemManager>().GetInstance().GetAll();
            rtmEntities.usesPositioningSystemCoordinate = InstanceManager.Singleton<PositioningSystemCoordinateManager>().GetInstance().GetAll();
            rtmEntities.uuid = "";

            return rtmEntities;
        }
    }
}
