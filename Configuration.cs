﻿using Dalamud.Configuration;
using Dalamud.Plugin;
using Newtonsoft.Json;
using System;

namespace OBSPlugin
{
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; }

        public bool Enabled = true;
        public bool UIDetection = true;
        public string SourceName = "FFXIV";
        public string Address = "ws://127.0.0.1:4455/"; // Default port was updated by obs-websocket. 
        public string Password = "";
        // Blur settings
        public int BlurSize = 3;
        public bool BlurAsync = true;
        public bool DrawBlurRect = false;
        public bool ChatLogBlur = true;
        public bool PartyListBlur = true;
        public bool TargetBlur = false;
        public bool TargetTargetBlur = true;
        public bool FocusTargetBlur = false;
        public bool NamePlateBlur = false;
        public bool CharacterBlur = false;
        public bool CharacterInspectBlur = false;
        public bool FriendListBlur = false;
        public bool HotbarBlur = false;
        public bool CastBarBlur = false;
        public int MaxNamePlateCount = 1;
        public int[] BlurredHotbars = Array.Empty<int>();
        // Record settings
        public string RecordDir = "";
        // public string FilenameFormat = "%CCYY-%MM-%DD %hh-%mm-%ss";
        public bool IncludeTerritory = true;
        public bool ZoneAsSuffix = false;
        public bool StartRecordOnCountDown = false;
        public bool StartRecordOnCombat = false;
        public bool StopRecordOnCombat = false;
        public bool CancelStopRecordOnResume = true;
        public int StopRecordOnCombatDelay = 5;
        public bool DontStopInCutscene = true;
        public bool ResetReplayBufferDirByTerritory = false;
        public bool SaveReplayBufferOnCombat = false;
        public int SaveReplayBufferOnCombatDelay = 0;


        public void Save()
        {
            Plugin.PluginInterface.SavePluginConfig(this);
        }
    }
}
