using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class SpotlightSystem : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;
    [SerializeField] Light spotlight;
    // Start is called before the first frame update

    private void Awake()
    {
        spotlight = GetComponent<Light>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowObject();
    }

    public void FollowObject()
    {
        this.gameObject.transform.LookAt(objectToFollow.transform);
    }

    public void TurnOff()
    {
        
    }

    public void TurnOn()
    {

    }


}
