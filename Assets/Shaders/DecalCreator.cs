using System.Collections.Generic;
using UnityEngine;

public class DecalCreator : MonoBehaviour
{       
    public GameObject targetDecal;

    private List<GameObject> decals = new List<GameObject>(128);

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
            tr.rotation = Quaternion.LookRotation(-hitInfo.normal);
            //tr.localScale = Vector3.one;

            decals.Add(decal);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            for (var i = 0; i < decals.Count; i++)
            {
                var decal = decals[i];
                Destroy(decal);
            }

            decals.Clear();
        }
    }
}