using StudioForge.BlockWorld;
using StudioForge.TotalMiner;
using StudioForge.TotalMiner.API;
using VehiclesMod.Screens;

namespace VehiclesMod
{
    class GUIPlugin : ITMPluginGUI
    {
        #region ITMPlugin

        NewGuiMenu ITMPluginGUI.GetItemCustomSetupScreen(ITMGame game, ITMPlayer player, GlobalPoint3D p, Item itemID)
        {
            switch (itemID)
            {
                case Item.Rasta:
                    return new VehicleSetupScreen(game, player, p);

                default:
                    return null;
            }
        }

        #endregion
    }
}
