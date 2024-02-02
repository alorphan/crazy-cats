using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Softbody
{

    public static float ColliderSize;
    public static float RigidbodyMass;
    public static float Spring;
    public static float Damper;
    public static Vector3 RootColliderPosition;
    public static RigidbodyConstraints Constraints;

    public static void Init(float collidersize, float rigidbodymass, float spring, float damper, RigidbodyConstraints constraints)
    {
        ColliderSize = collidersize;
        RigidbodyMass = rigidbodymass;
        Spring = spring;
        Damper = damper;
        Constraints = constraints;
    }
    public static Rigidbody AddCollider(ref GameObject go){
        return AddCollider(ref go, ColliderSize, RigidbodyMass, RootColliderPosition);
    }
    public static Rigidbody AddCollider(ref GameObject go, float size, float mass, Vector3 rootcolliderposition)
    {
        SphereCollider sc = go.AddComponent<SphereCollider>();
        sc.radius = size;
        sc.center = rootcolliderposition;
        Rigidbody rb = go.AddComponent<Rigidbody>();
        rb.mass = mass;
        rb.drag = 0f;
        rb.angularDrag = 0f;
        rb.constraints = Constraints;
        return rb;
    }


    public static SpringJoint AddSpring(ref GameObject go1, ref GameObject go2)
    {
        SpringJoint sp = AddSpring(ref go1, ref go2, Spring, Damper);
        
        return sp;
    }

    public static SpringJoint AddSpring(ref GameObject go1, ref GameObject go2, float spring, float damper)
    {
        SpringJoint sp = go1.AddComponent<SpringJoint>();
        sp.connectedBody = go2.GetComponent<Rigidbody>();
        sp.spring = spring;
        sp.damper = damper;
        return sp;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
