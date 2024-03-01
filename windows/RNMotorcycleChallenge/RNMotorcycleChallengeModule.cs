using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Motorcycle.Challenge.RNMotorcycleChallenge
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMotorcycleChallengeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMotorcycleChallengeModule"/>.
        /// </summary>
        internal RNMotorcycleChallengeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMotorcycleChallenge";
            }
        }
    }
}
