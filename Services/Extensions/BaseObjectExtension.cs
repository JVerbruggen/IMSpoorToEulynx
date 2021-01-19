using Models.TopoModels.EULYNX.rtmCommon;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Extensions
{
    public static class BaseObjectExtension
    {
        /// <summary>
        /// Reset UUID and allocate a new UUID based on object type and its properties.
        /// </summary>
        /// <param name="bo"></param>
        public static void AllocateUUID(this BaseObject bo)
        {
            bo.id = default;

            bo.id = UUIDService.NewFakeUUID(bo);
        }
    }
}
