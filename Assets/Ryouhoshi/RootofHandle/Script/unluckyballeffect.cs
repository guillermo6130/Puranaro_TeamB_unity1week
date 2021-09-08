using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unluckyballeffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	[SerializeField]
	[Tooltip("発生させるエフェクト(パーティクル)")]
	private ParticleSystem particle;

	/// <summary>
	/// 衝突した時
	/// </summary>
	/// <param name="collision"></param>
	private void OnCollisionEnter(Collision collision)
	{
		// 当たった相手が"UnLuckyBalll"tagを持っていたら
		if (collision.gameObject.tag == "UnLuckyBall")
		{
			// パーティクルシステムのインスタンスを生成する。
			ParticleSystem newParticle = Instantiate(particle);
			// 生成したパーティクルのpositionを不運玉と同じにする。
			newParticle.transform.position = collision.gameObject.transform.position;

			// パーティクルを発生させる。
			newParticle.Play();
			// インスタンス化したパーティクルシステムのGameObjectを削除する。(任意)
			// ※第一引数をnewParticleだけにするとコンポーネントしか削除されない。
			Destroy(newParticle.gameObject, 0.3f);
		}
	}
}

