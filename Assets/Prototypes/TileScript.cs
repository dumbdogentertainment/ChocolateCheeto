using System.Linq;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TileScript : MonoBehaviour
{
	private BoxCollider2D tileCollider;

    void Start()
    {
		this.tileCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
    }

    private void OnMouseUpAsButton()
    {
        ////ContactPoint2D[] contactPoints = new ContactPoint2D[16];

        ////this.tileCollider.GetContacts(contactPoints);
        
        ////foreach (var contact in contactPoints.Where(point => point.collider.tag == this.tag))
        ////{
        ////    var otherName = contact.collider.gameObject.name;
        ////    Debug.Log(otherName);
        ////}

        Destroy(this.gameObject, 0.25f);
    }
}