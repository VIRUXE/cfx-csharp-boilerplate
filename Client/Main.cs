using System;

using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace Client {
    public class Main : BaseScript {
        public Main() {
            Debug.WriteLine("Client started: ", Player.Local.Character.Handle);
        }
    }
}
