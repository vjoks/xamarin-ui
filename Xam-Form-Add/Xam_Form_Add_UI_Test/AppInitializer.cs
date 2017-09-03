using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xam_Form_Add_UI_Test
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                string apkPath = @"..\..\..\Xam-Form-Add\Xam_Form_Add.Android\bin\Debug\com.geg.Xam_Form_Add-Signed.apk";

                string motoGSerial = "ZY224DG22H";


                //.ApkFile(apkPath)
                // .InstalledApp("com.geg.Xam_Form_Add")
                //.DeviceSerial(motoGSerial)


                return ConfigureApp
                    .Android
                    .Debug()
                    .ApkFile(apkPath)
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

