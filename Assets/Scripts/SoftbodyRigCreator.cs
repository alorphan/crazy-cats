using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftbodyRigCreator : MonoBehaviour
{
    
    [Header ("Bones")]
    public GameObject root = null;
    public GameObject x0 = null;
    public GameObject x1 = null;
    public GameObject x2 = null;
    public GameObject x3 = null;
    public GameObject y0 = null;
    public GameObject y1 = null;
    public GameObject y2 = null;
    public GameObject y3 = null;
    public GameObject z0 = null;
    public GameObject z1 = null;
    [Header("Spring Joint Settings")]
    [Tooltip("Strength of Spring")]
    public float Spring = 100f;
    [Tooltip("Higher the value the faster the spring oscillation stops")]
    public float Damper = 0.2f;
    [Header("Other settings")]
    public float ColliderSize = 0.003f;
    public float RootColliderSize = 0.015f;
    public float RigidbodyMass = 1f;
    public Vector3 RootColliderPosition = new Vector3(0f, 0f, 0.05f);
    

    private void Start()
    {
        Softbody.Init(ColliderSize, RigidbodyMass, Spring, Damper, RigidbodyConstraints.FreezeRotation);

        Softbody.AddCollider(ref root, RootColliderSize, 1f, RootColliderPosition);
        Softbody.AddCollider(ref x0);
        Softbody.AddCollider(ref x1);
        Softbody.AddCollider(ref x2);
        Softbody.AddCollider(ref x3);
        Softbody.AddCollider(ref y0);
        Softbody.AddCollider(ref y1);
        Softbody.AddCollider(ref y2);
        Softbody.AddCollider(ref y3);
        Softbody.AddCollider(ref z0);
        Softbody.AddCollider(ref z1);
        
        
        
        Softbody.AddSpring(ref x0, ref root);
        Softbody.AddSpring(ref x1, ref root);
        Softbody.AddSpring(ref x2, ref root);
        Softbody.AddSpring(ref x3, ref root);
        Softbody.AddSpring(ref y0, ref root);
        Softbody.AddSpring(ref y1, ref root);
        Softbody.AddSpring(ref y2, ref root);
        Softbody.AddSpring(ref y3, ref root);
        Softbody.AddSpring(ref z0, ref root);
        Softbody.AddSpring(ref z1, ref root);
    }

    
    void Update()
    {
        
    }
}
