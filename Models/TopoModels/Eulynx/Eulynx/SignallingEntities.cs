using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class SignallingEntities
    {
        public static SignallingEntities GetSignallingEntities()
        {
            SignallingEntities signallingEntities = new SignallingEntities();

            signallingEntities.knowsAssetAndState = AssetAndState.GetAssetAndStates();
            signallingEntities.ownsAspect = Aspect.GetAspects();
            signallingEntities.ownsAssetGroup = AssetGroup.GetAssetGroups();
            signallingEntities.ownsAssetUser = AssetUser.GetAssetUsers();
            signallingEntities.ownsATPdevice_STUB = TpsDevice1.GetTpsDevices();
            signallingEntities.ownsAtpProtectiveDistance = TpsProtectionDistance.GetTpsProtectionDistances();
            signallingEntities.ownsAttachmentDocument = Attachment.GetAttachments();
            signallingEntities.ownsAutomatic = Automatic.GetAutomatics();
            signallingEntities.ownsBackToBackLocking = BackToBackLocking.GetBackToBackLockings();
            signallingEntities.ownsBaselineOfRuleSet = BaselineOfRuleSet.GetBaselineOfRuleSets();
            signallingEntities.ownsCableDuct = CableRoute.GetCableRoutes();
            signallingEntities.ownsCableRouteJunction = CableRouteJunction.GetCableRouteJunctions();
            signallingEntities.ownsCompositeRoute = CompositeRoute.GetCompositeRoutes();
            signallingEntities.ownsCompoundLogicalObject = CompoundLogicalObject.GetCompoundLogicalObjects();
            signallingEntities.ownsConditionSectionsClear = ConditionSectionsClear.GetConditionSectionsClears();
            signallingEntities.ownsConductorRail = ConductorRail.GetConductorRails();

            throw new NotImplementedException();

            return signallingEntities;
        }

    }
}
