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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CheckLicenseID
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the CheckLicenseIDRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("f6c71aa4-300d-4d0e-83ab-bec798549f11")]
    public partial class CheckLicenseIDRepository : RepoGenBaseFolder
    {
        static CheckLicenseIDRepository instance = new CheckLicenseIDRepository();
        CheckLicenseIDRepositoryFolders.AboutAppFolder _about;
        CheckLicenseIDRepositoryFolders.MeasureFitUntitledAppFolder _measurefituntitled;

        /// <summary>
        /// Gets the singleton class instance representing the CheckLicenseIDRepository element repository.
        /// </summary>
        [RepositoryFolder("f6c71aa4-300d-4d0e-83ab-bec798549f11")]
        public static CheckLicenseIDRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public CheckLicenseIDRepository() 
            : base("CheckLicenseIDRepository", "/", null, 0, false, "f6c71aa4-300d-4d0e-83ab-bec798549f11", ".\\RepositoryImages\\CheckLicenseIDRepositoryf6c71aa4.rximgres")
        {
            _about = new CheckLicenseIDRepositoryFolders.AboutAppFolder(this);
            _measurefituntitled = new CheckLicenseIDRepositoryFolders.MeasureFitUntitledAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f6c71aa4-300d-4d0e-83ab-bec798549f11")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The About folder.
        /// </summary>
        [RepositoryFolder("a9b246b4-cfc1-4e8d-a6a2-f58c523e592d")]
        public virtual CheckLicenseIDRepositoryFolders.AboutAppFolder About
        {
            get { return _about; }
        }

        /// <summary>
        /// The MeasureFitUntitled folder.
        /// </summary>
        [RepositoryFolder("50f4a009-a585-4287-beb1-72e2b605226d")]
        public virtual CheckLicenseIDRepositoryFolders.MeasureFitUntitledAppFolder MeasureFitUntitled
        {
            get { return _measurefituntitled; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class CheckLicenseIDRepositoryFolders
    {
        /// <summary>
        /// The AboutAppFolder folder.
        /// </summary>
        [RepositoryFolder("a9b246b4-cfc1-4e8d-a6a2-f58c523e592d")]
        public partial class AboutAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _sentinelidInfo;

            /// <summary>
            /// Creates a new About  folder.
            /// </summary>
            public AboutAppFolder(RepoGenBaseFolder parentFolder) :
                    base("About", "/form[@title='About']", parentFolder, 30000, null, true, "a9b246b4-cfc1-4e8d-a6a2-f58c523e592d", "")
            {
                _sentinelidInfo = new RepoItemInfo(this, "SentinelID", "text[@controlid='1719']", 30000, null, "5b1f8de7-2aaf-4f55-9f2a-0ea9837f43c3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a9b246b4-cfc1-4e8d-a6a2-f58c523e592d")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a9b246b4-cfc1-4e8d-a6a2-f58c523e592d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SentinelID item.
            /// </summary>
            [RepositoryItem("5b1f8de7-2aaf-4f55-9f2a-0ea9837f43c3")]
            public virtual Ranorex.Text SentinelID
            {
                get
                {
                    return _sentinelidInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SentinelID item info.
            /// </summary>
            [RepositoryItemInfo("5b1f8de7-2aaf-4f55-9f2a-0ea9837f43c3")]
            public virtual RepoItemInfo SentinelIDInfo
            {
                get
                {
                    return _sentinelidInfo;
                }
            }
        }

        /// <summary>
        /// The MeasureFitUntitledAppFolder folder.
        /// </summary>
        [RepositoryFolder("50f4a009-a585-4287-beb1-72e2b605226d")]
        public partial class MeasureFitUntitledAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _measurefituntitledInfo;

            /// <summary>
            /// Creates a new MeasureFitUntitled  folder.
            /// </summary>
            public MeasureFitUntitledAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MeasureFitUntitled", "/form[@title='MeasureFit - Untitled']", parentFolder, 30000, null, true, "50f4a009-a585-4287-beb1-72e2b605226d", "")
            {
                _measurefituntitledInfo = new RepoItemInfo(this, "MeasureFitUntitled", "titlebar[@accessiblerole='TitleBar']", 30000, null, "77b078c2-47cc-43cc-93dd-b015712a6f73");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("50f4a009-a585-4287-beb1-72e2b605226d")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("50f4a009-a585-4287-beb1-72e2b605226d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MeasureFitUntitled item.
            /// </summary>
            [RepositoryItem("77b078c2-47cc-43cc-93dd-b015712a6f73")]
            public virtual Ranorex.TitleBar MeasureFitUntitled
            {
                get
                {
                    return _measurefituntitledInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The MeasureFitUntitled item info.
            /// </summary>
            [RepositoryItemInfo("77b078c2-47cc-43cc-93dd-b015712a6f73")]
            public virtual RepoItemInfo MeasureFitUntitledInfo
            {
                get
                {
                    return _measurefituntitledInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}