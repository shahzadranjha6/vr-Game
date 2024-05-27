using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class DisableGrabbingHand : MonoBehaviour
{
    public GameObject LeftHandModel;    
    public GameObject RightHandModel;

    
    void Start()
    {
        XRGrabInteractable GrabInteractable = GetComponent<XRGrabInteractable>();
        
        GrabInteractable.selectEntered.AddListener(HideGrabbingHand);

        GrabInteractable.selectExited.AddListener(ShowGrabbingHand);

    }

    public void HideGrabbingHand(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag == "LeftHand")
        {
            LeftHandModel.SetActive(false);
        }
        else if(args.interactorObject.transform.tag == "RightHand")
        {
            RightHandModel.SetActive(false);
        }
        
    }

    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "LeftHand")
        {
            LeftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "RightHand")
        {
            RightHandModel.SetActive(true);
        }

    }
}
