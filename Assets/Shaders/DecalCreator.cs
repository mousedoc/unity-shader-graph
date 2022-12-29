using System.Collections.Generic;
using UnityEngine;

public class DecalCreator : MonoBehaviour
{
    public GameObject targetDecal;

    private List<GameObject> decals = new List<GameObject>(128);

    private void Update()
    {
        var flag = Input.GetMouseButtonDown(0) ||
                   Input.GetMouseButtonDown(1) ||
                   Input.GetKeyDown(KeyCode.Space);

        if (flag)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo) == false)
                return;

            if (targetDecal == null)
                return;

            var decal = GameObject.Instantiate(targetDecal);
            var tr = decal.transform;
            var normal = -hitInfo.normal;
            var zRot = new Vector3(0, 0, Random.Range(0, 360));

            tr.position = hitInfo.point;
            tr.rotation = Quaternion.Euler(zRot + Quaternion.LookRotation(normal).eulerAngles);

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