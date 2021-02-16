using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{

    private Transform cameraTransform;
    private Transform parentTransform;

    private Vector3 localRotation;
    private float cameraDistance = 15f;

    public float mouseSensitivity = 4f;
    public float scrollSensitivity = 2f;
    public float orbitDampening = 10f;
    public float scrollDampening = 6f;

    public bool CameraDisabled = false;

    // Start is called before the first frame update
    void Start()
    {
        this.cameraTransform = this.transform;
        this.parentTransform = this.transform.parent;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            CameraDisabled = !CameraDisabled;
        }


        if (!CameraDisabled)
        {
            //Rotation Based on the X and Y axis of the pointer
            if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                localRotation.x += Input.GetAxis("Mouse X") * mouseSensitivity;
                localRotation.y -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            }

            //Zoom Input for Mouse ScrollWheel
            if(Input.GetAxis("Mouse ScrollWheel") != 0f)
            {
                float ScrollAmount = Input.GetAxis("Mouse ScrollWheel") * scrollSensitivity;

                //Makes camera zoom faster the further away the mouse is from the mouse
                ScrollAmount *= (this.cameraDistance * 0.3f);

                this.cameraDistance += ScrollAmount * -1f;

                //stops the camera from moving from 1.5 units from the target to 100 units away
                this.cameraDistance = Mathf.Clamp(this.cameraDistance, 10f, 30f);
            }
        }

        //Camera Rig
        Quaternion qT = Quaternion.Euler(localRotation.y, localRotation.x, 0);
        this.parentTransform.rotation = Quaternion.Lerp(this.parentTransform.rotation, qT, Time.deltaTime * orbitDampening);

        if (this.cameraTransform.localPosition.z != this.cameraDistance * -1f)
        {
            this.cameraTransform.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this.cameraTransform.localPosition.z, this.cameraDistance * -1f, Time.deltaTime * scrollDampening));
        }
    }
}
