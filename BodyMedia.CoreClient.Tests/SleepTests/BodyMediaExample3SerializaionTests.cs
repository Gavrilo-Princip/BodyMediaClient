using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient.Tests.SleepTests
{
    [TestFixture]
    public class BodyMediaExample3SerializaionTests : BaseSerializationTest
    {
        private const string _xmlPath = "BodyMedia.CoreClient.Tests.ExampleXml.Sleep_Example3.xml";

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
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_averageLying_of_491()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(491, x.AverageLying);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_averageSleep_of_413()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(413, x.AverageSleep);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_totalLying_of_491()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(491, x.TotalLying);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_totalSleep_of_413()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(413, x.TotalSleep);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_totalSleep_of_0_84()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(0.84, x.Efficiency);
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
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_end_date_of_20110724()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 7, 24), x.EndDate);
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
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_days_collection_with_1_elements()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(1, x.SleepDays.Length);
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
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_efficiency_of_0_84()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(0.84, x.SleepDays[0].Efficiency);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_totalLying_of_491()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(491, x.SleepDays[0].TotalLying);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_totalSleep_of_413()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(413, x.SleepDays[0].TotalSleep);
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
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_SleepPeriods_collection_with_25_elements()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(25, x.SleepDays[0].SleepPeriods.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_5th_period_should_have_a_Duration_of_12()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(12, x.SleepDays[0].SleepPeriods[4].Duration);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_5th_period_should_have_a_MinuteIndex_of_111()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(111, x.SleepDays[0].SleepPeriods[4].MinuteIndex);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_5th_period_should_have_a_State_of_LYING()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(SleepState.Lying, x.SleepDays[0].SleepPeriods[4].State);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_8th_period_should_have_a_State_of_ASLEEP()
        {
            TestSerialization<Sleep>(_xmlPath, x =>
            {
                Assert.AreEqual(SleepState.Asleep, x.SleepDays[0].SleepPeriods[7].State);
            });
        }
    }
}
