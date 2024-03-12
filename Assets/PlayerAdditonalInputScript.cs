using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StarterAssets
{
    public class PlayerAdditonalInputScript : MonoBehaviour
    {
        public GameObject _torchHand;
        public GameObject _torchWaist;

        public void EquipTorch()
        {
            _torchHand.SetActive(true);
            _torchWaist.SetActive(false);
        }
        public void UnequipTorch()
        {
            _torchHand.SetActive(false);
            _torchWaist.SetActive(true);
        }


    }
}

