﻿using System;
using GizmoLab.Gameplay;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

namespace GizmoLab.Infrastructure.Database
{
    public class PlayerGameData
    {
        #region Consts

        private static readonly PlayerGameData instance = new PlayerGameData();

        public static PlayerGameData Instance
        {
            get { return instance; }
        }

        #endregion

        #region Fields

        private string _weapon = "";
        private float _health = 0;
        private int _score = 0;

        public float Health
        {
            get { return _health; }
            set { _health += value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score += value; }
        }

        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        #endregion

        #region Constructors

        private PlayerGameData()
        {
        }

        #endregion

        #region Functions

        #endregion
    }
}