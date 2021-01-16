
using UnityEngine;

public class Weight : MonoBehaviour
{
    public float distanceFromLastLink = 0.3f;

    //Connect weight to the last link of rope
  public void ConnectRopeEnd( Rigidbody2D endRb)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = endRb;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, -distanceFromLastLink);

    }
}
