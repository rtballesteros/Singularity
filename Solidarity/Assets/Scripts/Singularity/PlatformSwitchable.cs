using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singularity
{
    public class PlatformSwitchable : MonoBehaviour, ISwitchableObject
    {
        public Vector3 movementVector;
        public GameObject switchToSubscribe;
        public float totalTime;

        private Vector3 startPosition;
        private Vector3 goalLocation;
        private float time = 0f;
        private Vector3 currlocation;

        void Start()
        {
            switchToSubscribe.GetComponent<Switch>().SubscribeToSwitch(On, Off);
            startPosition = transform.position;
            currlocation = startPosition;
        }

        public void On()
        {
            // could use lerp here and some time function to make the platform "move"
            transform.position += movementVector;
        }

        public void Off()
        {
            transform.position = startPosition;
        }
    }
}
