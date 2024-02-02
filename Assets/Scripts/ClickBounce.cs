using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClickBounce : MonoBehaviour
{
    [SerializeField]
    public Vector3 startpos;
    [SerializeField]
    public Vector3 endpos;
    [SerializeField]
    public Vector3 startscale = new Vector3(100f, 100f, 100f);
    [SerializeField]
    public Vector3 endscale = new Vector3(100f, 50f, 100f);

    [SerializeField]
    float rate;
    [SerializeField]
    public float speed = 1.0f;
    [SerializeField]
    public float loweramount = -0.8f;
    [SerializeField]
    public float scalingFramesleft = 10;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        startpos = gameObject.transform.position;
        endpos = startpos + new Vector3(0f, loweramount, 0f);
        rb = gameObject.GetComponent<Rigidbody>();
        //if (Input.GetMouseButtonDown(0)) {
        //     scalingFramesleft = 10;
        //}

        //if (scalingFramesleft > 0){
        //    transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale * 0.5f, Time.deltaTime * 10);
        //    scalingFramesleft--;
        //}
    }

    private void OnMouseDown()
    {
        Debug.Log("Click!");
        rb.velocity = new Vector3(0, 50, 0);
    }

    
}
