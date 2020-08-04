using System;
using UnityEngine;

namespace UnityEditor.ShaderGraph
{
    public struct ParentGroupChange
    {
        public IGroupItem groupItem;
        public Guid oldGroupGuid;
        public Guid newGroupGuid;
    }
}

