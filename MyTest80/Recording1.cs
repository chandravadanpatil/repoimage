﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest80
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("1453399a-0e40-450b-aa0c-a0652235d964", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest80Repository repository.
        /// </summary>
        public static MyTest80Repository repo = MyTest80Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.TxtUserName' at 4;4.", repo.RxMainFrame.RxTabIntroduction.TxtUserNameInfo, new RecordItemIndex(0));
            repo.RxMainFrame.RxTabIntroduction.TxtUserName.Click(new Location(TxtUserName_Screenshot1, "4;4", TxtUserName_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'RxMainFrame.RxTabIntroduction.TxtUserName'.", repo.RxMainFrame.RxTabIntroduction.TxtUserNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.RxTabIntroduction.TxtUserName.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.BtnSubmitUserName' at 4;4.", repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserName.Click(new Location(BtnSubmitUserName_Screenshot1, "4;4", BtnSubmitUserName_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.RxLinkBtnReset' at 4;4.", repo.RxMainFrame.RxTabIntroduction.RxLinkBtnResetInfo, new RecordItemIndex(3));
            repo.RxMainFrame.RxTabIntroduction.RxLinkBtnReset.Click(new Location(RxLinkBtnReset_Screenshot1, "4;4", RxLinkBtnReset_Screenshot1_Options));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage TxtUserName_Screenshot1
        { get { return repo.RxMainFrame.RxTabIntroduction.TxtUserNameInfo.GetScreenshot1(new Rectangle(70, 6, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions TxtUserName_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BtnSubmitUserName_Screenshot1
        { get { return repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserNameInfo.GetScreenshot1(new Rectangle(55, 9, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BtnSubmitUserName_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage RxLinkBtnReset_Screenshot1
        { get { return repo.RxMainFrame.RxTabIntroduction.RxLinkBtnResetInfo.GetScreenshot1(new Rectangle(11, 8, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions RxLinkBtnReset_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
