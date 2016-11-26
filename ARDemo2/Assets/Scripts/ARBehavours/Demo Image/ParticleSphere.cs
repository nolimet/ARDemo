using System.Collections;
using System.Linq;

using UnityEngine;
public class ParticleSphere :MonoBehaviour
{

    [SerializeField]
    ParticleSystem pSys;
    ParticleSystem.Particle[] ps = new ParticleSystem.Particle[1000];
    Vector2[] dir = new Vector2[1000];

    [Tooltip("Set Local Position")]
    public Vector3 SphereCenter = new Vector3(0, 2.5f, 0);
    public float SphereRadius = 7f;

    public void Start()
    {
        for (int i = 0; i < dir.Length; i++)
        {
            dir[i] = new Vector3(Random.Range(-90f, 90f), Random.Range(-180f, 180f), 0);
        }
        ParticleSystem.EmissionModule e = pSys.emission;
        e.rate = 30f;
       
        //for (int i = 0; i < ps.Length; i++)
        //{
        //    ps[i].position = SpherePos(SphereRadius, dir[i].x, dir[i].y, SphereCenter);
        //    ps[i].velocity = (SphereCenter - ps[i].position) * -1;
        //    ps[i].startColor = Color.white;
        //    ps[i].startSize = 1f;
        //}
        //pSys.SetParticles(ps,1000);

       
    }

    public void Update()
    {
        pSys.GetParticles(ps);
        for (int i = 0; i < ps.Length; i++)
        {
            //if(ps[i].velocity == Vector3.zero)
            //{
               
            //    ps[i].position = SpherePos(SphereRadius * (ps[i].lifetime/7f), dir[i].x, dir[i].y, SphereCenter);
            //}

            ps[i].position = SpherePos(SphereRadius * (ps[i].lifetime / 7f), dir[i].x, dir[i].y, SphereCenter);
        }

        pSys.SetParticles(ps, 1000);
    }

    public static Vector3 SpherePos(float @radius, float @thera, float @pheta, Vector3 @SphereCenter)
    {
        Vector3 output = new Vector3();
        float x = @SphereCenter.x + @radius * Mathf.Sin(@thera) * Mathf.Cos(@pheta);
        float y = @SphereCenter.y + @radius * Mathf.Sin(@thera) * Mathf.Sin(@pheta);
        float z = @SphereCenter.z + @radius * Mathf.Cos(@pheta);

        output = new Vector3(x, y, z);
        return output;
    }
}
