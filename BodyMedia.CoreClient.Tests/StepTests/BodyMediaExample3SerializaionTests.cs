using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient.Tests.StepTests
{
    [TestFixture]
    public class BodyMediaExample3SerializaionTests : BaseSerializationTest
    {
        private const string _xmlPath = "BodyMedia.CoreClient.Tests.ExampleXml.Step_Example3.xml";

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_there_should_not_be_an_exception()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_not_be_null()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.IsNotNull(x);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_averageSteps_of_12296()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(12296, x.AverageSteps);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_totalSteps_of_36889()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(36889, x.TotalSteps);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_start_date_of_20110615()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 15), x.StartDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_end_date_of_20110617()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 17), x.EndDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_non_null_LastSync()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.LastSync);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_TimeStamp_of_20120621T181047_1000()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2012, 6, 21, 18, 10, 47).AddHours(6), x.LastSync.TimeStamp);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_Type_of_UPLOAD_SYNC_WIN()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual("UPLOAD_SYNC_WIN", x.LastSync.Type);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_non_null_days_collection()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.StepDays);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_days_collection_with_3_elements()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(3, x.StepDays.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_date_of_20110615()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 15), x.StepDays[0].Date);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_totalSteps_of_12652()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(12652, x.StepDays[0].TotalSteps);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_non_null_SleepPeriods_collection()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.StepDays[0].StepHours);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_day_should_have_a_SleepPeriods_collection_with_24_elements()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(24, x.StepDays[0].StepHours.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_2nd_day_should_have_a_SleepPeriods_collection_with_24_elements()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(24, x.StepDays[1].StepHours.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_3rd_day_should_have_a_SleepPeriods_collection_with_24_elements()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(24, x.StepDays[2].StepHours.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_2nd_days_9th_hour_should_have_steps_of_2234()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(2234, x.StepDays[1].StepHours[8].TotalSteps);
            });
        }
    }
}
