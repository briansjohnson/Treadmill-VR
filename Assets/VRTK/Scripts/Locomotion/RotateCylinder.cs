namespace RotateCylinder
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using VRTK;

    public class RotateCylinder : MonoBehaviour
    {

        //private float rotateSpeed;

        //public Dictionary<Transform, float> previousYPositions;

        //public List<Transform> trackedObjects;
        
        /*public float RotateSpeed
        {
            get
            {
                return rotateSpeed;
            }
            set
            {
                rotateSpeed = value;
            }
        }
        */
        //public GameObject spinCylinder;

        // Use this for initialization
        void Start()
        {
            
        }        
        // Update is called once per frame
        void Update()
        {

            //transform.Rotate(0, 0, Time.deltaTime * rotateSpeed);
        }

        //public VRTK_MoveInPlace.ControlOptions testing = VRTK_MoveInPlace.ControlOptions.ControllersOnly;

        
        public void FixedUpdate()
        {
            //
            //float speed = Mathf.Clamp(((speedScale * 350) * (CalculateListAverage() / trackedObjects.Count)), 0f, maxSpeed);
            //
            //Trying to call deltaYpostion variable from VRTK_MoveInPlace().CalculateListAverage()
            //Then apply that changing float value to rotateSpeed
            //GameObject vrtkScripts = GameObject.Find("[VRTK_Scripts]");
            //VRTK_MoveInPlace vrtkScripts = GetComponent<VRTK_MoveInPlace>();
            //previousYPositions = vrtkScripts.previousYPositions;
            //Transform trackedObj = vrtkScripts.trackedObjects[i];

            
            
            //RotateSpeed = rotationY.maxSpeed;
            //deltaY.deltaYPosition = rotateSpeed;
            //Debug.Log(rotateSpeed);
          
            //transform.Rotate(0, 0, Time.deltaTime * RotateSpeed);

        }
    }
}
