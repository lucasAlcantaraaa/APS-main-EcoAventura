using System.Diagnostics;
using UnityEngine;

public class MooveCamera : MonoBehaviour
{

    public GameObject target;
    public Vector3 adjust;

    public float limitLeft;
    public float limitTop;

    protected Camera myCamera;

    void Start()
    {
        myCamera = gameObject.GetComponent<Camera>();
    }

    private void LateUpdate()
    {
      if(!target)
      {
        return;
      }  

      Vector3 position = target.transform.position + adjust;

      if(position.y > limitTop)
      {
        position.y = limitTop;
      }
      if(position.x < limitLeft)
      {
        position.x = limitLeft;
      }






      myCamera.transform.position = position;
    }

  
}