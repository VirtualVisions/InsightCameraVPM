
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Vowgan
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class InsightCameraToggle : UdonSharpBehaviour
    {
        
        [Header("If used in a UI Button, use SendCustomEvent with the event '_OnPress'")]
        public InsightController Controller;

        public override void Interact()
        {
            _OnPress();
        }

        public void _OnPress()
        {
            Controller._ToggleCamera();
        }
        
    }
}