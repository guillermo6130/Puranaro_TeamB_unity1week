using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luckyballEffect : MonoBehaviour
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
	[Tooltip("����������G�t�F�N�g(�p�[�e�B�N��)")]
	private ParticleSystem particle;

	/// <summary>
	/// �Փ˂�����
	/// </summary>
	/// <param name="collision"></param>
	private void OnCollisionEnter(Collision collision)
	{
		// �����������肪"LuckyBalll"tag�������Ă�����
		if (collision.gameObject.tag == "LuckyBall")
		{
			// �p�[�e�B�N���V�X�e���̃C���X�^���X�𐶐�����B
			ParticleSystem newParticle = Instantiate(particle);
			// ���������p�[�e�B�N����position���K�^�ʂƓ����ɂ���B
			newParticle.transform.position = collision.gameObject.transform.position;
			
			// �p�[�e�B�N���𔭐�������B
			newParticle.Play();
			// �C���X�^���X�������p�[�e�B�N���V�X�e����GameObject���폜����B(�C��)
			// ����������newParticle�����ɂ���ƃR���|�[�l���g�����폜����Ȃ��B
			Destroy(newParticle.gameObject, 5.0f);
		}
	}
}