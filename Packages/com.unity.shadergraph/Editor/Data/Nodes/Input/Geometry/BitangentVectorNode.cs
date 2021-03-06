using UnityEngine;
using UnityEditor.Graphing;
using UnityEditor.ShaderGraph.Internal;

namespace UnityEditor.ShaderGraph
{
    [Title("Input", "Geometry", "Bitangent Vector")]
    public class BitangentVectorNode : GeometryNode, IMayRequireBitangent
    {
        public const int kOutputSlotId = 0;
        public const string kOutputSlotName = "Out";

        public BitangentVectorNode()
        {
            name = "Bitangent Vector";
            UpdateNodeAfterDeserialization();
        }


        public sealed override void UpdateNodeAfterDeserialization()
        {
            AddSlot(new Vector3MaterialSlot(kOutputSlotId, kOutputSlotName, kOutputSlotName, SlotType.Output, new Vector4(0, 0, 1)));
            RemoveSlotsNameNotMatching(new[] { kOutputSlotId });
        }

        public override string GetVariableNameForSlot(int slotId)
        {
            return string.Format("IN.{0}", space.ToVariableName(InterpolatorType.BiTangent));
        }

        public NeededCoordinateSpace RequiresBitangent(ShaderStageCapability stageCapability)
        {
            return space.ToNeededCoordinateSpace();
        }
    }
}
