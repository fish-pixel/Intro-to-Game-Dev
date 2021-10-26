using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject triggerParticle;
    public GameObject collisionParticle;


    //Gets executed when something enters this trigger, or when this object enters a trigger
    private void OnTriggerEnter(Collider other)
    {
       if (triggerParticle != null)
        {
            //The triggerParticle will be spawned at the location of this object
            //with the same rotation as this object
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collisionParticle != null)
        {
            Instantiate(collisionParticle, this.transform.position, this.transform.rotation);
        }
    }

}
