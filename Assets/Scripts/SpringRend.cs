using UnityEngine;
using System.Collections;

public class SpringRend : MonoBehaviour {

	// line renderer options
	public Color c1, c2;
	public float lineWidth;

	private Transform point2;
	private LineRenderer lr;

	private void Start () {
		// find second object
		point2 = transform.GetComponentInParent<SpringJoint>().connectedBody.transform;

		// create and setup line renderer
		lr = gameObject.AddComponent<LineRenderer>();
		lr.material = new Material(Shader.Find("Particles/Additive"));
		lr.SetColors(c1, c2);
		lr.SetWidth(lineWidth,lineWidth);
		lr.SetVertexCount(2);
	}

	private void Update () {
		// update position
		lr.SetPosition(0,transform.position);
		lr.SetPosition(1,point2.position);
	}
}
