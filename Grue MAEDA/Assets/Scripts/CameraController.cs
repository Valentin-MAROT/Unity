using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera[] cameras;
    public AudioListener[] audioListeners;
    private int currentCameraIndex;

    void Start()
    {
        currentCameraIndex = 0;

        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
            audioListeners[i].gameObject.SetActive(false);
        }

        if (cameras.Length > 0)
        {
            cameras[0].gameObject.SetActive(true);
        }
        
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.C)){
            currentCameraIndex++;
            if(currentCameraIndex < cameras.Length){
                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
                audioListeners[currentCameraIndex - 1].gameObject.SetActive(false);
                cameras[currentCameraIndex].gameObject.SetActive(true);
                audioListeners[currentCameraIndex].gameObject.SetActive(true);
            }
            else{
                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
                audioListeners[currentCameraIndex - 1].gameObject.SetActive(false);
                currentCameraIndex = 0;
                cameras[currentCameraIndex].gameObject.SetActive(true);
                audioListeners[currentCameraIndex].gameObject.SetActive(true);
            }
        }
    }
}
