using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

public class RotationSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float elapsedTime = (float)Time.ElapsedTime;

        Entities
            .WithAll<RotateTag>()
            .ForEach((ref Translation translation, ref Rotation rotation, in SpeedComponent speed) =>
            {
                rotation.Value = math.normalize(quaternion.RotateY(speed.Value * elapsedTime));
            }).Schedule();
    }
}
