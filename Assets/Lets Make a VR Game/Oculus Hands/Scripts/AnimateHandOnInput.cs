using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public InputActionProperty fistAnimationActio;
    public InputActionProperty gunFingerAnimationAction;
    public Animator handAnimator;

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);
       
        if(pinchAnimationAction.action.triggered)
        {
            Debug.Log("trigger value" + triggerValue);
        }
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
        if (gripAnimationAction.action.triggered)
        {
            Debug.Log("Grip value" + gripValue);
        }

    }
}
