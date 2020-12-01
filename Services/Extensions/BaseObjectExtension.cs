using Models.TopoModels.Eulynx.Common;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Extensions
{
    public static class BaseObjectExtension
    {
        public static void AllocateUUID(this BaseObject bo)
        {
            bo.uuid = default;

            bo.uuid = UUIDService.NewFakeUUID(bo);
        }
    }
}
