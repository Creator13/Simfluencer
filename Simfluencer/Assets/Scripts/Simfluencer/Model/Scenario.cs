﻿using System.Collections.Generic;
using UnityEngine;

namespace Simfluencer.Model {
    public enum ScenarioEnding {
        ConspiracyPositive,
        ConspiracyNegative,
        SciencePositive,
        ScienceNegative
    }
    
    [CreateAssetMenu(menuName = "Simfluencer/Scenario")]
    public class Scenario : ScriptableObject {
        [SerializeField] private string scenarioName;
        public string ScenarioName => scenarioName;

        [SerializeField] private Sprite[] endBackgrounds = new Sprite[4];

        [SerializeField] private List<Post> posts;

        private void Awake() {
            foreach (var post in posts) {
                post.scenario = this;
            }
        }

        public Sprite GetBackground(ScenarioEnding scen) {
            return endBackgrounds[(int) scen];
        }
    }
}
