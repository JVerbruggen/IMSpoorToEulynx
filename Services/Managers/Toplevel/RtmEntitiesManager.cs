using Models.TopoModels.Eulynx.EULYNX_XSD;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Managers.Assets;
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

            UpdateRtmEntities(rtmEntities, situation);

            return rtmEntities;
        }

        public RtmEntities UpdateRtmEntities(RtmEntities rtmEntities, tSituation situation)
        {
            //rtmEntities.ownsBufferstop = VehicleStop.GetVehicleStops();
            //rtmEntities.ownsPoint = Turnout.GetTurnouts();
            //rtmEntities.ownsRouteBody = RouteBody.GetRouteBodies();
            rtmEntities.ownsSignal = InstanceManager.Singleton<SignalRTMManager>().GetInstance().GetAll();
            //rtmEntities.usesCablingTopology = CablingTopology.GetCablingTopology();
            //rtmEntities.usesLinearLocation = LinearLocation.GetLinearLocations();
            rtmEntities.usesTrackTopology = InstanceManager.Singleton<TrackTopologyManager>().GetInstance().GetTrackTopology(situation.RailInfrastructure.RailTopology);
            rtmEntities.usesSpotLocation = InstanceManager.Singleton<SpotLocationManager>().GetInstance().GetAll();
            rtmEntities.usesPositioningSystem = InstanceManager.Singleton<PositioningSystemManager>().GetInstance().GetAll();
            rtmEntities.usesPositioningSystemCoordinate = InstanceManager.Singleton<PositioningSystemCoordinateManager>().GetInstance().GetAll();
            rtmEntities.uuid = "";

            return rtmEntities;
        }
    }
}
