﻿using ColossalFramework;
using ICities;
using UnityEngine;

namespace Debugger
{

    public class Mod : IUserMod
    {

        public string Name
        {
            get { return "Debugger"; }
        }

        public string Description
        {
            get { return "Helper plugin for mod developers"; }
        }

    }
    public class ModLoad : LoadingExtensionBase
    {

        public override void OnLevelLoaded(LoadMode mode)
        {
            var controller = GameObject.FindObjectOfType<CameraController>();
            controller.gameObject.AddComponent<Debugger>();
        }

    }

}