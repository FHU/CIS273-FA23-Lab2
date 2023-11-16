using PrayerScheduler;

namespace UnitTests
{
    [TestClass]
    public class PrayerSchedulerUnitTests
	{

        [TestMethod]
        public void TestAdd1()
        {
            PrayerScheduler.PrayerScheduler prayerScheduler = new();

            prayerScheduler.AddPrayer(new Prayer() { ID = 1, Text = "test1", IsDaily = true, Category = "Names of God", Scripture = "John 3:16" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 2, Text = "test2", IsDaily = false, Category = "Names of God", Scripture = "1 John 3:1" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 3, Text = "test3", IsDaily = true, Category = "Biblical Prayers", Scripture = "Psalm 23:1" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 4, Text = "test4", IsDaily = false, Category = "Promises", Scripture = "Jeremiah 29:11" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 5, Text = "test5", IsDaily = true, Category = "God Is", Scripture = "Exodus 3:14" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 6, Text = "test6", IsDaily = false, Category = "In Christ", Scripture = "2 Corinthians 5:17" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 7, Text = "test7", IsDaily = true, Category = "Petition", Scripture = "Philippians 4:6-7" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 8, Text = "test8", IsDaily = false, Category = "Names of God", Scripture = "Psalm 46:1" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 9, Text = "test9", IsDaily = true, Category = "Biblical Prayers", Scripture = "Matthew 6:9-13" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 10, Text = "test10", IsDaily = false, Category = "Promises", Scripture = "Romans 8:28" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 11, Text = "test11", IsDaily = true, Category = "God Is", Scripture = "Psalm 139:7-10" });


            Assert.AreEqual(6, prayerScheduler.NumDailyPrayers);
            Assert.AreEqual(5, prayerScheduler.NumNonDailyPrayers);

            prayerScheduler.AddPrayer(new Prayer() { ID = 12, Text = "test12", IsDaily = false, Category = "In Christ", Scripture = "Ephesians 2:8-9" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 13, Text = "test13", IsDaily = true, Category = "Petition", Scripture = "James 5:16" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 14, Text = "test14", IsDaily = false, Category = "Names of God", Scripture = "Psalm 145:18" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 15, Text = "test15", IsDaily = true, Category = "Biblical Prayers", Scripture = "1 Thessalonians 5:16-18" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 16, Text = "test16", IsDaily = false, Category = "Promises", Scripture = "Isaiah 41:10" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 17, Text = "test17", IsDaily = true, Category = "God Is", Scripture = "John 14:6" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 18, Text = "test18", IsDaily = false, Category = "In Christ", Scripture = "Romans 12:2" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 19, Text = "test19", IsDaily = true, Category = "Petition", Scripture = "Matthew 7:7-8" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 20, Text = "test20", IsDaily = false, Category = "Names of God", Scripture = "Psalm 27:1" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 21, Text = "test21", IsDaily = true, Category = "Biblical Prayers", Scripture = "Philippians 4:13" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 22, Text = "test22", IsDaily = false, Category = "Promises", Scripture = "Romans 15:13" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 23, Text = "test23", IsDaily = true, Category = "God Is", Scripture = "Psalm 103:8" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 24, Text = "test24", IsDaily = false, Category = "In Christ", Scripture = "Colossians 3:17" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 25, Text = "test25", IsDaily = true, Category = "Petition", Scripture = "Philippians 4:19" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 26, Text = "test26", IsDaily = false, Category = "Names of God", Scripture = "Proverbs 3:5-6" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 27, Text = "test27", IsDaily = true, Category = "Biblical Prayers", Scripture = "Psalm 19:14" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 28, Text = "test28", IsDaily = false, Category = "Promises", Scripture = "Jeremiah 33:3" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 29, Text = "test29", IsDaily = true, Category = "God Is", Scripture = "Revelation 1:8" });
            prayerScheduler.AddPrayer(new Prayer() { ID = 30, Text = "test30", IsDaily = false, Category = "In Christ", Scripture = "Galatians 2:20" });

            Assert.AreEqual(6, prayerScheduler.NumDailyPrayers);
            Assert.AreEqual(5, prayerScheduler.NumNonDailyPrayers);
        }

        [TestMethod]
        public void TestAdd2()
        {
            PrayerScheduler.PrayerScheduler prayerScheduler = new();

            prayerScheduler.AddPrayer(new Prayer() { ID = 1, Text = "test1", IsDaily = true, Category = "Names of God", Scripture = "John 3:16", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 2, Text = "test2", IsDaily = false, Category = "Names of God", Scripture = "1 John 3:1", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 3, Text = "test3", IsDaily = true, Category = "Biblical Prayers", Scripture = "Psalm 23:1", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 4, Text = "test4", IsDaily = false, Category = "Promises", Scripture = "Jeremiah 29:11", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 5, Text = "test5", IsDaily = true, Category = "God Is", Scripture = "Exodus 3:14", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 6, Text = "test6", IsDaily = false, Category = "In Christ", Scripture = "2 Corinthians 5:17", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 7, Text = "test7", IsDaily = true, Category = "Petition", Scripture = "Philippians 4:6-7", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 8, Text = "test8", IsDaily = false, Category = "Names of God", Scripture = "Psalm 46:1", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 9, Text = "test9", IsDaily = true, Category = "Biblical Prayers", Scripture = "Matthew 6:9-13", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 10, Text = "test10", IsDaily = false, Category = "Promises", Scripture = "Romans 8:28", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 11, Text = "test11", IsDaily = true, Category = "God Is", Scripture = "Psalm 139:7-10", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 12, Text = "test12", IsDaily = false, Category = "In Christ", Scripture = "Ephesians 2:8-9", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 13, Text = "test13", IsDaily = true, Category = "Petition", Scripture = "James 5:16", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 14, Text = "test14", IsDaily = false, Category = "Names of God", Scripture = "Psalm 145:18", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 15, Text = "test15", IsDaily = true, Category = "Biblical Prayers", Scripture = "1 Thessalonians 5:16-18", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 16, Text = "test16", IsDaily = false, Category = "Promises", Scripture = "Isaiah 41:10", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 17, Text = "test17", IsDaily = true, Category = "God Is", Scripture = "John 14:6", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 18, Text = "test18", IsDaily = false, Category = "In Christ", Scripture = "Romans 12:2", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 19, Text = "test19", IsDaily = true, Category = "Petition", Scripture = "Matthew 7:7-8", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 20, Text = "test20", IsDaily = false, Category = "Names of God", Scripture = "Psalm 27:1", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 21, Text = "test21", IsDaily = true, Category = "Biblical Prayers", Scripture = "Philippians 4:13", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 22, Text = "test22", IsDaily = false, Category = "Promises", Scripture = "Romans 15:13", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 23, Text = "test23", IsDaily = true, Category = "God Is", Scripture = "Psalm 103:8", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 24, Text = "test24", IsDaily = false, Category = "In Christ", Scripture = "Colossians 3:17", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 25, Text = "test25", IsDaily = true, Category = "Petition", Scripture = "Philippians 4:19", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 26, Text = "test26", IsDaily = false, Category = "Names of God", Scripture = "Proverbs 3:5-6", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 27, Text = "test27", IsDaily = true, Category = "Biblical Prayers", Scripture = "Psalm 19:14", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 28, Text = "test28", IsDaily = false, Category = "Promises", Scripture = "Jeremiah 33:3", IsAnswered = false });
            prayerScheduler.AddPrayer(new Prayer() { ID = 29, Text = "test29", IsDaily = true, Category = "God Is", Scripture = "Revelation 1:8", IsAnswered = true });
            prayerScheduler.AddPrayer(new Prayer() { ID = 30, Text = "test30", IsDaily = false, Category = "In Christ", Scripture = "Galatians 2:20", IsAnswered = false });

        }


    }
}

