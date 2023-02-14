using System;
using UnityEngine;
using TMPro;


    public class GameManager : MonoBehaviour
    {
        
        //Global Values
        public byte LevelNumber
        {
            get { return _levelNumber; }
            private set
            {
                _levelNumber = value;
                levelText.text = _levelNumber.ToString();
            }
        }

        public ushort TieNumber
        {
            get { return _tieNumber; }
            private set
            {
                _tieNumber = value;
                tieNumberText.text = _tieNumber.ToString();
            }
        }

        public byte LivesNumber
        {
            get { return _livesNumber; }
            private set
            {
                _livesNumber = (byte)Mathf.Clamp(value, 0, 99);
                tieNumberText.text = _livesNumber.ToString();
            }
        }

        public ushort WingNumber
        {
            get
            {
                return _wingNumber;
            }
            private set
            {
                _wingNumber = value;
                wingNumberText.text = _wingNumber.ToString();
            }
        }

        //
        private byte _levelNumber = 1;
        private ushort _tieNumber = 0;
        private byte _livesNumber = 2;
        private ushort _wingNumber = 54;

        //For UI Binding
        [SerializeField] private TMP_Text levelText;
        [SerializeField] private TMP_Text tieNumberText;
        [SerializeField] private TMP_Text livesNumberText;
        [SerializeField] private TMP_Text wingNumberText;

        
        
        
        private static GameManager instance;

        public static GameManager GetInstance()
        {
            return instance;
        }

        void Awake()
        {
            if (instance != null)
            {
                Debug.LogError("There are more GameManager in the scene.");
            }

            instance = this;
        }

        void Start()
        {
            levelText.text = LevelNumber.ToString();
            tieNumberText.text = TieNumber.ToString();
            livesNumberText.text = LivesNumber.ToString();
            wingNumberText.text = WingNumber.ToString();
        }
    }
