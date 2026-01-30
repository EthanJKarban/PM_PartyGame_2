using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class addtocamera : MonoBehaviour
{
    public CinemachineTargetGroup targetGroup;

    public void addToGroup (PlayerInput input)
    {
        targetGroup.Targets.Add(new() { Weight = 1, Object = input.transform });
    }
}
