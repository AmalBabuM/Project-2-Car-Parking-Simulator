using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelColliders colliders;
    public WheelMeshes meshes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ApplyWheelPosition();
    }
    void ApplyWheelPosition()
    {
        UpdateWheel(colliders.FRWheel, meshes.FRMesh);
        UpdateWheel(colliders.FLWheel, meshes.FLMesh);
        UpdateWheel(colliders.BRWheel, meshes.BRMesh);
        UpdateWheel(colliders.BLWheel, meshes.BLMesh);

    }
    private void UpdateWheel(WheelCollider col,MeshRenderer wheelMesh)
    {
        Quaternion quat;
        Vector3 position;
        col.GetWorldPose(out position, out quat);
        wheelMesh.transform.position = position;
        wheelMesh.transform.rotation = quat;
    }

}
[System.Serializable]
public class WheelColliders
{
    public WheelCollider FRWheel;
    public WheelCollider FLWheel;
    public WheelCollider BRWheel;
    public WheelCollider BLWheel;
}
[System.Serializable]
public class WheelMeshes
{
    public MeshRenderer FRMesh;
    public MeshRenderer FLMesh;
    public MeshRenderer BRMesh;
    public MeshRenderer BLMesh;
}
