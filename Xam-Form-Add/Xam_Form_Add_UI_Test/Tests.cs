using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xam_Form_Add_UI_Test
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }


        [Test]
        public void Add_51_With_32_For_Result_83()
        {
            app.EnterText("EntryA", "51");
            app.EnterText("EntryB", "32");

            app.Tap("ButtonAdd");

            var appResult = app.Query("LabelResult").First(result => result.Text == "83");
            Assert.IsTrue(appResult != null, "Result Label has unexpected value");

        }

        [Test]
        public void Subtract_12_With_5_For_Result_7()
        {
            app.EnterText("EntryA", "12");
            app.EnterText("EntryB", "5");

            app.Tap("ButtonSubtract");

            var appResult = app.Query("LabelResult").First(result => result.Text == "7");
            Assert.IsTrue(appResult != null, "Result Label has unexpected value");

        }


    }
}

