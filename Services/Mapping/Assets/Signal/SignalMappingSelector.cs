using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Text;
using SignalIMSpoor = Models.TopoModels.IMSpoor.V1_2_3.Signal;
using SignalEULYNX = Models.TopoModels.Eulynx.EULYNX_Signalling.Signal;
using Models.TopoModels.IMSpoor.V1_2_3;

namespace Services.Mapping.Assets.Signal
{
    public class SignalMappingSelector : MappingSelector<SignalIMSpoor, SignalEULYNX>
    {
        public override IMapping<SignalIMSpoor, SignalEULYNX> Select(SignalIMSpoor input)
        {
            IMapping<SignalIMSpoor, SignalEULYNX> mapping;
            if (input.signalType == tSignalEnum.Controlled)
            {
                mapping = new SignalMappingControlled();
            }
            else
            {
                mapping = new SignalMappingDefault();
            }
            return mapping;
        }
    }
}
