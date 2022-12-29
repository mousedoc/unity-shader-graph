using UnityEngine;

public class DecalCreator : MonoBehaviour
{
    public GameObject targetDecal;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo) == false)
                return;

            if (targetDecal == null)
                return;

            var decal = GameObject.Instantiate(targetDecal);
            var tr = decal.transform;
            tr.position = hitInfo.point;
            tr.rotation = Quaternion.Euler(ray.direction);
            tr.localScale = Vector3.one;
        }
    }
}