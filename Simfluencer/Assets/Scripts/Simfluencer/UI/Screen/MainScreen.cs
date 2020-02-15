﻿using cvanbattum.Audio;

namespace Simfluencer.UI.Screen {
    public class MainScreen : Screen {
        protected override void Show() {
            SoundManager.Instance.PlayMusic();
        }
    }
}
