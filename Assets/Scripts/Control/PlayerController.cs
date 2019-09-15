using UnityEngine;

class PlayerController : MonoBehaviour {


    void Update()
    {
         if (Input.GetMouseButton(0)) {
            MoveToCursor();
        }
    }

    private void MoveToCursor() 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHitInfo;
        bool hasHit = Physics.Raycast(ray, out raycastHitInfo);
        if (hasHit) {
            GetComponent<Mover>().MoveTo(raycastHitInfo.point);
        }
    }

}