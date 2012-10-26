using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient.Tests.SleepTests
{
    [TestFixture]
    public class BodyMediaExample2SerializaionTests : BaseSerializationTest
    {
        private const string _xmlPath = "BodyMedia.CoreClient.Tests.ExampleXml.Sleep_Example2.xml";

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_there_should_not_be_an_exception()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_not_be_null()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.IsNotNull(x);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_averageLying_of_369()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(369, x.AverageLying);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_averageSleep_of_337()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(337, x.AverageSleep);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_totalLying_of_1108()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(1108, x.TotalLying);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_totalSleep_of_1010()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(1010, x.TotalSleep);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_totalSleep_of_0_91()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(0.91, x.Efficiency);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_start_date_of_20110724()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 7, 24), x.StartDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_end_date_of_20110726()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 7, 26), x.EndDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_non_null_LastSync()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.LastSync);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_TimeStamp_of_20120618T151047_1000()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2012, 6, 21, 15, 10, 47).AddHours(6), x.LastSync.TimeStamp);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_Type_of_UPLOAD_SYNC_MAC()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual("UPLOAD_SYNC_MAC", x.LastSync.Type);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_non_null_days_collection()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.SleepDays);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_days_collection_with_3_elements()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(3, x.SleepDays.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_date_of_20110724()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 7, 24), x.SleepDays[0].Date);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_TotalLying_of_491()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(491, x.SleepDays[0].TotalLying);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_TotalSleep_of_413()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(413, x.SleepDays[0].TotalSleep);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_Efficiency_of_0_84()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(0.84, x.SleepDays[0].Efficiency);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_non_null_SleepPeriods_collection()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.SleepDays[0].SleepPeriods);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_SleepPeriods_collection_with_0_elements()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(0, x.SleepDays[0].SleepPeriods.Length);
            });
        }
    }
}
