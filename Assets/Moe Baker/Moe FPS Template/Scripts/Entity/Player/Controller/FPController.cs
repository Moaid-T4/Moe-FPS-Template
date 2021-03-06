﻿using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

using Moe.GameFramework;

namespace ARFC
{
	public partial class FPController
	{
        protected override void Awake()
        {
            base.Awake();

            Game.Pause.OnStateChanged += OnPause;
        }

        public virtual void InitRemote()
        {
            enabled = false;

            CameraRig.Camera.gameObject.SetActive(false);
        }

        protected override void UpdateInputModule()
        {
            if (Game.Pause.State == GamePauseState.None)
                base.UpdateInputModule();
        }

        protected virtual void OnPause(GamePauseState state)
        {
            InputModule.Clear();
        }
    }
}